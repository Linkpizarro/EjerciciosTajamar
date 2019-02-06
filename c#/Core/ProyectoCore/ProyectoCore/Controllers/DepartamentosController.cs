using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoCore.Repositories;

namespace ProyectoCore.Controllers
{
    public class DepartamentosController : Controller
    {
        IRepositoryHospital repo;
        public DepartamentosController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetDepartamentos());
        }
    }
}