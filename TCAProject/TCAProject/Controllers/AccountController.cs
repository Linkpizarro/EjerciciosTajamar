using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TCAProject.Interfaces;
using TCAProject.Models.Class;

namespace TCAProject.Controllers
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
        public ActionResult Register(User user,String pass,String repPass, HttpPostedFileBase file)
        {
            if (ModelState.IsValid) {
                if (file != null && file.ContentLength > 0)
                {
                    user.Image_User = Server.MapPath("~/Media/Img/Avatars");
                }
                String error = null;
                if (repo.Register(user,pass,repPass,file,ref error))
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
                case 0: return RedirectToAction("NotFound","Error");
                case -1: return RedirectToAction("TimeOut", "Error");
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
                 return RedirectToAction("NotFound", "Error");
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
               return RedirectToAction("NotFound", "Error");
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

        //POST: Login
        [HttpPost]
        public ActionResult Login(String email,String password)
        {
            String error = null;
            User user = repo.Login(email, password, ref error);
            
            if( user != null)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Id_User.ToString(), DateTime.Now, DateTime.Now.AddMinutes(60), true,user.Id_Rol.ToString());
                String encryp = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie("User", encryp);
                Response.Cookies.Add(cookie);

                if (user.Id_Rol == 1)
                {
                    return RedirectToAction("Pubs", "Client");
                }

                return RedirectToAction("Parties", "Player");
            }

            ViewBag.Error = error;
            return View();
        }

        // GET: LogOut
        public ActionResult Logout()
        {
            HttpContext.User = new GenericPrincipal(new GenericIdentity(""), null);
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["User"];
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            Session["Client"] = null;
            Session["Player"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}
