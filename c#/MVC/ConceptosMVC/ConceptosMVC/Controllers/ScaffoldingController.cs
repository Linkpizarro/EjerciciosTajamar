using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConceptosMVC.Models;

namespace ConceptosMVC.Controllers
{
    public class ScaffoldingController : Controller
    {
        HelperDepartamento h = new HelperDepartamento();
        // GET: Index
        public ActionResult Index()
        {
            return View(h.GetDepts());
        }
        // POST: Index
        public ActionResult Index(String dept)
        {
            return RedirectToAction("Update","Scaffolding",new {dept = dept });
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(DEPT dept)
        {
            if (ModelState.IsValid)
            {
                h.Create(dept);
                return RedirectToAction("Index","Scaffolding");
            }
            return View(dept);
        }

        //GET: Update
        public ActionResult Update(String dept)
        {
            return View(h.GetDept(dept));
        }
        //POST: Update
        [HttpPost]
        public ActionResult Update(DEPT dept)
        {
            if (ModelState.IsValid)
            {
                h.Update(dept);
                return RedirectToAction("Index", "Scaffolding");
            }
            return View(dept);
        }

    }
}