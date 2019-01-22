using SeguridadEmpleados.Attributes;
using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadEmpleados.Controllers
{
    [AutorizacionEmpleados]
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController()
        {
            repo = new RepositoryEmpleados();
        }
        // GET: Index
        public ActionResult Index()
        {
            return View(repo.Subordinados(int.Parse(HttpContext.User.Identity.Name)));
        }
    }
}