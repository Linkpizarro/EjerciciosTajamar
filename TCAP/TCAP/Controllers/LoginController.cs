using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP.Models;
using TCAP.Models.Helpers;

namespace TCAP.Controllers
{
    public class LoginController : Controller
    {
        HelperLogin h = new HelperLogin();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Index(String email,String password)
        {
            if (h.ValidateLogin(email, password))
            {
                return RedirectToAction("Home","User");
            }
            else
            {
                ViewBag.Info = "El email o la contraseña son incorrectos.";
                return View();
            }
            
        }
    }
}