using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Design.Models;

namespace Design.Controllers
{
    public class HomeController : Controller
    {
        HelperDepartamento h = new HelperDepartamento();
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //POST: Index
        [HttpPost]
        public ActionResult Index(String dept_no)
        {
            return View(h.GetDepartamento(dept_no));
        }
    }
}