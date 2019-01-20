using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Controllers
{
    public class AccountController : Controller
    {
        IRepositoryAccount repo;

        public AccountController(IRepositoryAccount repo)
        {
            this.repo = repo;
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid) {
                if (user.File_User != null && user.File_User.ContentLength > 0)
                {
                    user.Image_User = Server.MapPath("~/Media/Img/Avatars");
                }
                String error = null;
                if (repo.Register(user,ref error))
                {
                    TempData["Success"] = "Se ha registrado correctamente. Se le ha enviado un correo de confirmación.";
                    return RedirectToAction("Login", "Account");
                }
                ViewBag.Error = error;   
            }
            return View(user);
        }

        //GET : Confirm
        public ActionResult Confirm(String token)
        {
            User user = repo.Confirm(token);

            switch (user.Id_User)
            {
                case 0: /*error*/;break;
                case -1: /*error*/;break;
            }

            if (user.Id_Rol == 1)
            {
                Session["Client"] = user.Id_User;
                return RedirectToAction("ClientConfirm","Account");
            }

            Session["Player"] = user.Id_User;
            return RedirectToAction("PlayerConfirm", "Account");
        }

        //GET : ClientConfirm
        public ActionResult ClientConfirm()
        {
            if (Session["Client"] is null)
            {
                //redireccionar a pagina de error.
            }
            Client client = new Client()
            {
                Id_User = int.Parse(Session["Client"].ToString())
            };
            return View(client);
        }

        //POST : ClientConfirm
        [HttpPost]
        public ActionResult ClientConfirm(Client client)
        {
            if (ModelState.IsValid)
            {
                String error = null;

                //Aseguramos que el id no ha sido cambiado.
                client.Id_User = int.Parse(Session["Client"].ToString());

                if (repo.ClientConfirm(client,ref error))
                {
                    Session["Client"] = null;
                    TempData["Success"] = "Ha confirmado la cuenta correctamente.";
                    return RedirectToAction("Login", "Account");
                }

                ViewBag.Error = error;
            }

            return View(client);
        }

        //GET : PlayerConfirm
        public ActionResult PlayerConfirm()
        {
            if (Session["Player"] is null)
            {
                //redireccionar a pagina de error.
            }
            Player player = new Player()
            {
                Id_User = int.Parse(Session["Player"].ToString())
            };
            return View(player);
        }

        //POST : PlayerConfirm
        [HttpPost]
        public ActionResult PlayerConfirm(Player player)
        {
            if (ModelState.IsValid)
            {

                String error = null;

                //Aseguramos que el id no ha sido cambiado.
                player.Id_User = int.Parse(Session["Player"].ToString());

                if (repo.PlayerConfirm(player, ref error))
                {
                    Session["Player"] = null;
                    TempData["Success"] = "Ha confirmado la cuenta correctamente.";
                    return RedirectToAction("Login", "Account");
                }

                ViewBag.Error = error;
            }

            return View(player);
        }

        //GET: Login
        public ActionResult Login()
        {
            if (!(TempData["Success"] is null))
            {
                ViewBag.Success = TempData["Success"].ToString();
            }

            return View();
        }
    }
}
