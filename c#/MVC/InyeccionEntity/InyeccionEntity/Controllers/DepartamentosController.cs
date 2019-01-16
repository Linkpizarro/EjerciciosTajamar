using InyeccionEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionEntity.Controllers
{
    public class DepartamentosController : Controller
    {
        IRepositoryDepartamento repo;
        public DepartamentosController(IRepositoryDepartamento repo)
        {
            this.repo = repo;
        }
        // GET: Index
        public ActionResult Index()
        {
            return View(this.repo.GetDepartamentos());
        }
    }
}