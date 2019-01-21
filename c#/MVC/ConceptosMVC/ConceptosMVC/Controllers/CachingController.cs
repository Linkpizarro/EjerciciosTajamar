using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptosMVC.Controllers
{
    public class CachingController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: HoraSistema
        [OutputCache(CacheProfile = "perfil30")]
       
        public ActionResult HoraSistema()
        {
            ViewBag.Hora = "Fecha: " +
                DateTime.Now.ToLongDateString() +
                ". Hora: " + DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}