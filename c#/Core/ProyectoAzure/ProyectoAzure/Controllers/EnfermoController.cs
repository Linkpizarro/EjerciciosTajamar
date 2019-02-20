using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAzure.Repositories;

namespace ProyectoAzure.Controllers
{
    public class EnfermoController : Controller
    {
        IRepositoryEnfermo repo;
        public EnfermoController(IRepositoryEnfermo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetEnfermos());
        }
        [HttpPost]
        public IActionResult Index(int inscripcion)
        {
            int afec = repo.EliminarEnfermo(inscripcion);
            ViewData["sms"] = "Enfermos eliminados " + afec;
            return View(repo.GetEnfermos());
        }
    }
}