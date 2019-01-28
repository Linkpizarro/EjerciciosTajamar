using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxEmpleados.Controllers
{
    public class EmpleadoController : Controller
    {
        RepositoryEmpleado repo = new RepositoryEmpleado();
        // GET: Empleado
        public ActionResult Index()
        {
            return View(repo.GetEmpleados());
        }
        public PartialViewResult _DetalleEmpleado(int id)
        {
            return PartialView(repo.GetEmpleado(id));
        }
    }
}