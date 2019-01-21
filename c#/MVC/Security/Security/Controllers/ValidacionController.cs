using Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Security.Controllers
{
    public class ValidacionController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(String usuario,String password)
        {
            ControlUsuarios control = new ControlUsuarios();
            if (control.ExisteUsuario(usuario, password))
            { 

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,usuario,DateTime.Now,DateTime.Now.AddMinutes(15),true,control.Role);
                String datosCifrados = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie("TicketUsuario", datosCifrados);
                Response.Cookies.Add(cookie);

                return RedirectToAction("Index","Administracion");
            }
         
            return View();
        }
        // GET: ErrorAcceso
        public ActionResult ErrorAcceso()
        {
            return View();
        }
    }
}