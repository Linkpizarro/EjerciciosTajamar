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
            if (!(TempData["image"] is null))
            {
                ViewBag.image = TempData["image"];
            }
            return View();
        }
        // POST: Register
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid) {

                if (user.File_User != null && user.File_User.ContentLength > 0)
                {
                    
                    String name = "random" + user.File_User.FileName;
                    string path = Path.Combine(Server.MapPath("~/Images"),
                                                Path.GetFileName(name));
                    user.File_User.SaveAs(path);
                    user.Image_User = name;
                    TempData["image"] = user.Image_User;
                }

                repo.Register(user);
                return RedirectToAction("Register", "Account");

            }

            return View(user);
        }
    }
}