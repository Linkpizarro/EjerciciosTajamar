using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    public class PersonasController : Controller
    {
        public List<Persona> GetPersonas()
        {
            return new List<Persona>{
            new Persona
            {
               Id = 1,
               Nombre = "Adrian",
               Apellidos = "Garcia",
               Edad = 23
            },

            new Persona
            {
               Id = 2,
               Nombre = "Lucia",
               Apellidos = "Ramos",
               Edad = 15
            },

            new Persona
            {
               Id = 3,
               Nombre = "Vitorino",
               Apellidos = "Lopez",
               Edad = 31
            },

            new Persona
            {
               Id = 4,
               Nombre = "Luis",
               Apellidos = "Gallego",
               Edad = 34
            },
         };
        }

        // GET: Personas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarPersonas()
        {
            ViewBag.Titulo = "Lista de Personas";
            List<Persona> lista = this.GetPersonas();
            return View(lista);
        }

    }
}