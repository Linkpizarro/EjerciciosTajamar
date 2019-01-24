using SeguridadPlantilla.Attributes;
using SeguridadPlantilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadPlantilla.Controllers
{
    [AuthorizeEmp]
    public class PlantillaController : Controller
    {
        RepositoryPlantilla repo = new RepositoryPlantilla();
        // GET: Plantilla
        public ActionResult Index()
        {
            return View(repo.GetPlantilla());
        }
    }
}