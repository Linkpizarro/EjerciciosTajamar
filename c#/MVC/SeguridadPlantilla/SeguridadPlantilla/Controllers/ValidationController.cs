using SeguridadPlantilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SeguridadPlantilla.Controllers
{
    public class ValidationController : Controller
    {
        RepositoryValidation repo = new RepositoryValidation();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        // POST: Login
        [HttpPost]
        public ActionResult Login(String surname,String password)
        {
            Plantilla emp = repo.ValidateUser(surname,int.Parse(password)) ;
            if (emp != null)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,password, DateTime.Now, DateTime.Now.AddMinutes(10), true,surname);
                String cifrado = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie("TicketEmpleado", cifrado);
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Plantilla");
            }

            ViewBag.Error = "Usuario/Contaseña incorrectos.";
            return View();
        }
        // GET: LogOut
        public ActionResult LogOut()
        {
            HttpContext.User = new GenericPrincipal(new GenericIdentity(""), null);
            FormsAuthentication.SignOut();
            HttpCookie cookie = Request.Cookies["TicketEmpleado"];
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index", "Home");
        }
    }
}