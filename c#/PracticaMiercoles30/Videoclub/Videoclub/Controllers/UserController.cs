using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Videoclub.Attributes;
using Videoclub.Repositories;

namespace Videoclub.Controllers
{
    public class UserController : Controller
    {
        RepositoryUser repo = new RepositoryUser();
        // GET: Login
        public ActionResult Login()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"].ToString();
            }
            return View();
        }

        //POST:Login
        [HttpPost]
        public ActionResult Login(String email,String pass){
            int result = 0;
            int.TryParse(pass,out result);
            if (result == 0)
            {
                TempData["Error"] = "Email/contraseña incorrectos.";
                return RedirectToAction("Login", "User");
            }

            if (repo.Login(email,int.Parse(pass)))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, pass.ToString(), DateTime.Now, DateTime.Now.AddMinutes(60), true, "");
                String encryp = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie("Cliente", encryp);
                Response.Cookies.Add(cookie);

                return RedirectToAction("Peliculas", "Videoclub");
            }
            TempData["Error"] = "Email/contraseña incorrectos.";
            return RedirectToAction("Login", "User");
        }

        //GET :Pedidos
        [AuthorizeCliente]
        public ActionResult Pedidos()
        {
            return View(repo.GetPedidos(int.Parse(HttpContext.User.Identity.Name)));
        }

        // GET: LogOut
        public ActionResult Logout()
        {
            HttpContext.User = new GenericPrincipal(new GenericIdentity(""), null);
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["Cliente"];
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            return RedirectToAction("Peliculas", "Videoclub");
        }

        // GET: _Nav
        public ActionResult _Nav()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return PartialView(repo.GetCliente(int.Parse(HttpContext.User.Identity.Name)));
            }

            return PartialView();
           
        }
    }
}