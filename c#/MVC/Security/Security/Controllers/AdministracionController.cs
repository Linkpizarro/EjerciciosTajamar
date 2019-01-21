using Security.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Security.Controllers
{
    [AutorizacionUsers]
    public class AdministracionController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            return View();
        }
    }
}