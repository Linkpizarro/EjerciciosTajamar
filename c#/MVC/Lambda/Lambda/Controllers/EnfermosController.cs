using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lambda.Models;

namespace Lambda.Controllers
{
    public class EnfermosController : Controller
    {
        HelperEnfermos h = new HelperEnfermos();
        // GET: Enfermos
        public ActionResult Enfermos()
        {
            return View(h.GetEnfermos());
        }
        // POST: Enfermos
        [HttpPost]
        public ActionResult Enfermos(String inscripcion)
        {
            if (h.DeleteEnfermo(inscripcion))
            {
                ViewBag.Success = "Se ha eliminado al enfermo Correctamente.";
            }
            else
            {
                ViewBag.Error = "Se ha producido un error al intentar eliminar al Enfermo.";
            }
            return View(h.GetEnfermos());
        }
    }
}