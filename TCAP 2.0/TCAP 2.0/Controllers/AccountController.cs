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
                    return RedirectToAction("Register", "Account");
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
                TempData["Client"] = user.Id_User;
                return RedirectToAction("ClientConfirm","Account");
            }

            TempData["Player"] = user.Id_User;
            return RedirectToAction("PlayerConfirm", "Account");
        }

        //GET : ClientConfirm
        public ActionResult ClientConfirm()
        {
            if (TempData["Client"] is null)
            {
                //redireccionar a pagina de error.
            }
            Client client = new Client()
            {
                Id_User = int.Parse(TempData["Client"].ToString())
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
                if (repo.ClientConfirm(client,ref error))
                {
                    return RedirectToAction("Register", "Account");
                }
            }

            return View(client);
        }

        //GET : PlayerConfirm
        public ActionResult PlayerConfirm()
        {
            if (TempData["Player"] is null)
            {
                //redireccionar a pagina de error.
            }
            Player player = new Player()
            {
                Id_User = int.Parse(TempData["Player"].ToString())
            };
            return View(player);
        }

        //POST : PlayerConfirm
        [HttpPost]
        public ActionResult PlayerConfirm(Player player)
        {
            if (ModelState.IsValid)
            {
                //ok
            }

            return View(player);
        }
    }
}
