using InyeccionEntity.Models;
using InyeccionEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyeccionEntity.Controllers
{
    public class HospitalesController : Controller
    {
        IRepositoryHospital repo;

        public HospitalesController(IRepositoryHospital repo)
        {
            this.repo = repo;
        }

        // GET: Index
        public ActionResult Index()
        {
            return View(repo.GetHospitales());
        }
    }
}