using ClienteServicioEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteServicioEmpleados.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController()
        {
            this.repo = new RepositoryEmpleados();
        }
        public ActionResult Empleados()
        {
            ViewBag.Oficios = repo.GetOficios();
            return View();
        }
        [HttpPost]
        public ActionResult Empleados(String oficio)
        {
            ViewBag.LastOficio = oficio;
            ViewBag.Oficios = repo.GetOficios();
            return View(repo.GetEmpleadosOficio(oficio));
        }
    }
}