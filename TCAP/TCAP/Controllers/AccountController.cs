using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP.Models;
using TCAP.Models.Helpers;


namespace TCAP.Controllers
{
    public class AccountController : Controller
    {
        HelperAccount h = new HelperAccount();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        // POST: Login
        [HttpPost]
        public ActionResult Login(String email, String password)
        {
            if (h.ValidateLogin(email,password))
            {
                return RedirectToAction("Home", "User",new {rol = 2});
            }
            else
            {
                ViewBag.Error = "El email o la contraseña son incorrectos.";
                return View();
            }
        }
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        //POST: Register
        [HttpPost]
        public ActionResult Register(String user, String name, String surname, String email, String password,
            String country, String cp_zip)
        {
            if (h.InsertUser(user,name,surname,email,password,country,cp_zip))
            {
                ViewBag.Success = "Se ha registrado correctamente.";
                return View("Login");
            }
            else
            {
                ViewBag.Error = "Se ha Producido un error en el registro... Intentelo mas tarde.";
                return View();
            }
        }
    }
}