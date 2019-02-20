using AzureMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureMVC.Controllers
{
    public class EnfermosController : Controller
    {
        RepositoryHospital repo;
        public EnfermosController(RepositoryHospital repo)
        {
            this.repo = repo;
        }
        // GET: Enfermos
        public ActionResult Index()
        {
            return View(repo.GetEnfermos());
        }
        [HttpPost]
        public ActionResult Index(int inscripcion)
        {
            int afect = repo.EliminarEnfermo(inscripcion);
            ViewBag.sms = "Has eliminado a " + afect + " enfermo";
            return View(repo.GetEnfermos());
        }
    }
}