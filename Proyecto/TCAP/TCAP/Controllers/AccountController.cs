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

       //****falta validaciones en el tel y mob de cliente****
       //***NECESITO VIEWS Y PROCEDURES PARA TODO****

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
            String error = null;
            USERS result = h.Login(email,password,ref error);

            if (!(result is null))
            {
                if (result.ID_ROL == 1)
                {
                    TempData["Client"] = result;
                    return RedirectToAction("Home", "Client");
                }
                else
                {
                    TempData["Player"] = result;
                    return RedirectToAction("Home", "Player");
                }
            }

            ViewBag.Error = error;
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
            String error = null;

            if (h.ValidateRegister(user, name, surname, email, password,ref error))
            {
                TempData["Success"] = "Registro completado.Se ha enviado un email de confirmación.";
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Error = error;

            ViewBag.OldUser = user;
            ViewBag.OldName = name;
            ViewBag.OldSurname = surname;
            ViewBag.OldEmail = email;

            return View();
        }
        //GET: UserConfirm
        public ActionResult UserConfirm(String token = null)
        {
            String error = null;
            USERS result = h.Confirm(token,ref error);
            if (result is null)
            {
                ViewBag.Error = error;
            }
            else
            {
                ViewBag.Token = token;
            }

            if (!(TempData["OldClient"] is null))
            {
                ViewBag.OldDni = ((List<String>)TempData["OldClient"])[0];
                ViewBag.OldTel = ((List<String>)TempData["OldClient"])[1];
                ViewBag.OldMob = ((List<String>)TempData["OldClient"])[2];
            }

            if (!(TempData["OldPlayer"] is null))
            {
                ViewBag.OldNick = ((List<String>)TempData["OldPlayer"])[0];
                ViewBag.OldAge = ((List<String>)TempData["OldPlayer"])[1];
                ViewBag.OldSex = ((List<String>)TempData["OldPlayer"])[2];
                ViewBag.OldDesc = ((List<String>)TempData["OldPlayer"])[3];
            }
            if(!(TempData["Error"] is null))
            {
                ViewBag.Error = TempData["Error"];
            }

            return View(result);
           
        }
        //POST: UserConfirm
        [HttpPost]
        public ActionResult UserConfirm(String rol,String token,String nickname,String age,String sex,String description,
            String dni,String telephone,String mobile)
        {
            //Faltan los old...

            String error = null;
            if (rol == "1")
            {
                
                if (h.ValidateClientConfirm(token, dni, telephone, mobile,ref error))
                {
                    TempData["Success"] = "Ha confirmado Su cuenta Correctamente.";
                    return RedirectToAction("Login", "Account");
                }

                TempData["OldClient"] = new List<String>() {
                   dni,
                   telephone,
                   mobile
                };
            }
            else
            {

                if (h.ValidatePlayerConfirm(token, nickname, age, sex, description,ref error))
                {
                    TempData["Success"] = "Ha confirmado Su cuenta Correctamente.";
                    return RedirectToAction("Login", "Account");
                }

                TempData["OldPlayer"] = new List<String>() {
                   nickname,
                   age,
                   sex,
                   description
                 };

            }
           
            TempData["Error"]= error;
            return RedirectToAction("UserConfirm","Account",new {token = token});
        }
    }
}