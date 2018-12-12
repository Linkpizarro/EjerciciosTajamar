using MVCEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemplo1.Controllers
{
    public class InfoController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: ControllerView 
        public ActionResult Business()
        {
            Connect n = new Connect();
            return View(n.GetData("GETEMPRESAS", "Empresa"));
        }
    }
}