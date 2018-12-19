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
            if (!(TempData["Success"] is null))
            {
                ViewBag.Success = TempData["Success"].ToString();
            }

            return View();
        }
        // POST: Login
        [HttpPost]
        public ActionResult Login(String email, String password)
        {
            User u = h.Login(email, password);
            if (!(u.Email is null) && u.Rol == 1)
            {
                TempData["obj"] = u;
                return RedirectToAction("Home", "Client");
            }
            else if (!(u.Email is null) && u.Rol == 2)
            {
                TempData["obj"] = u;
                return RedirectToAction("Home", "Player");
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
            if (h.Register(user,name,surname,email,password,country,cp_zip))
            {
                TempData["Success"] = "Se ha registrado correctamente.";
                return RedirectToAction("Login","Account");
            }
            else
            {
                ViewBag.Error = "Se ha Producido un error en el registro... Intentelo mas tarde.";
                return View();
            }
        }
        //GET: PlayerConfirm
        public ActionResult PlayerConfirm(String token = null)
        {
            User u = new User();
            u = h.ValidateToken(token);
            return View(u);
        }
    }
}