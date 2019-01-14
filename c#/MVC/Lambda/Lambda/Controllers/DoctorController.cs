using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lambda.Models;

namespace Lambda.Controllers
{
    public class DoctorController : Controller
    {
        HelperDoctor h = new HelperDoctor();
        // GET: Doctor
        public ActionResult Index()
        {
            ViewBag.Hospitales = h.GetHospitales();
            return View();
        }
        // POST: Doctor
        [HttpPost]
        public ActionResult Index(List<int> hospitales)
        {
            ViewBag.Hospitales = h.GetHospitales();
            return View(h.GetDoctores(hospitales));
        }
    }
}