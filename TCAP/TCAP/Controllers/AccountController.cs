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

        //NO HAY VALIDACIONES FIABLES
        //SOLO PUEDO CONFIRMAR JUGADORES.

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
            List<Object> result = h.Login(email,password);

            if (!(result[0] is null))
            {
                if (((USERS)result[0]).ID_ROL == 1)
                {
                    TempData["Client"] = result[0];
                    return RedirectToAction("Home", "Client");
                }
                else
                {
                    TempData["Player"] = result[0];
                    return RedirectToAction("Home", "Player");
                }
            }

            ViewBag.Error = result[1];
            return View();
        }
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        //POST: Register
        [HttpPost]
        public ActionResult Register(String user, String name, String surname, String email, String password)
        {
            if (h.Register(user,name,surname,email,password))
            {
                TempData["Success"] = "Registro completado.Se ha enviado un email de confirmación.";
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Error = "Se ha producido un error en el registro.";
            ViewBag.OldUser = user;
            ViewBag.OldName = name;
            ViewBag.OldSurname = surname;
            ViewBag.OldEmail = email;
            return View();
        }
        //GET: UserConfirm
        public ActionResult UserConfirm(String token = null)
        {
            List<Object> result = h.Confirm(token);
            if (result[0] is null)
            {
                ViewBag.Error = result[1];
            }
            else
            {
                ViewBag.Token = token;
            }
           
            return View(result[0]);
           
        }
        //POST: UserConfirm
        [HttpPost]
        public ActionResult UserConfirm(String rol,String token,String nickname,String age,String sex,String description,
            String dni,String telephone,String mobile)
        {
            //Faltan los old...

            if (rol == "1")
            {
                //Falta validaciones de los campos aquí...

                if (h.ClientConfirm(token, dni, telephone, mobile))
                {
                    TempData["Success"] = "Ha confirmado Su cuenta Correctamente.";
                    return RedirectToAction("Login", "Account");
                }
            }
            else
            {
                //Falta validaciones de los campos aquí...

                if (h.PlayerConfirm(token, nickname, age, sex, description))
                {
                    TempData["Success"] = "Ha confirmado Su cuenta Correctamente.";
                    return RedirectToAction("Login", "Account");
                }
            }
           
            ViewBag.Error = "Se ha producido un error.";
            return RedirectToAction("UserConfirm","Account",new {token = token});
        }
    }
}