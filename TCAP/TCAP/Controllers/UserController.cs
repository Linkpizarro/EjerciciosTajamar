using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCAP.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Home(int rol)
        {
            ViewBag.Rol = rol;
            return View();
        }
    }
}