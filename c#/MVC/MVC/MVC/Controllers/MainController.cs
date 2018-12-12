using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            ViewData["MENSAJE"] = "Hoy es "+DateTime.Now.DayOfWeek+" "+DateTime.Now.Day;
            return View();
        }
    }
}