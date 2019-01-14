using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lambda.Models;

namespace Lambda.Controllers
{
    public class ValidacionesController : Controller
    {
        // GET: Correcto
        public ActionResult Correcto()
        {
            return View();
        }
        // GET: InsertarPersona
        public ActionResult InsertarPersona()
        {
            return View();
        }
        // POST: InsertarPersona
        [HttpPost]
        public ActionResult InsertarPersona(Persona persona)
        {
            if (ModelState.IsValid)
            {
                return View("Correcto");
            }

            return View(persona);
        }
    }
}