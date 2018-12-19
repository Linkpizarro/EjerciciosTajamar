using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaLINQ.Models;

namespace PruebaLINQ.Controllers
{
    public class HomeController : Controller
    {
        HelperHome h = new HelperHome();
        // GET: Index
        public ActionResult Index()
        {
            return View(h.GetAllDept());
        }
        //POST: Index
        [HttpPost]
        public ActionResult Index(String dept_no,String dnombre,String loc)
        {
            h.SetDept(dept_no, dnombre, loc);
            return View(h.GetAllDept());
        }
    }
}