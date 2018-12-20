using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaLINQ.Models;

namespace PruebaLINQ.Controllers
{
    public class EmpController : Controller
    {
        HelperEmp h = new HelperEmp();   
        // GET: Emp
        public ActionResult Index()
        {
            ViewBag.oficios = h.GetOficios();
            return View(h.GetEmp());
        }
        // POST: Emp
        [HttpPost]
        public ActionResult Index(String oficio,String increment)
        {
            ViewBag.oficios = h.GetOficios();

            if (!(oficio is null) && increment != "")
            {
                h.UpdateSalario(oficio,increment);
            }
            else
            {
                ViewBag.error = "No se ha podido realizar la modificación.";
            }
            
            return View(h.GetEmp());

        }
    }
}