using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaLINQ.Models;

namespace PruebaLINQ.Controllers
{
    public class DeptEmpController : Controller
    {
        HelperDeptEmp h = new HelperDeptEmp();
        // GET: DeptEmp
        public ActionResult Index()
        {
            ViewBag.dept = h.GetDept();
            return View();
        }
        // POST: DeptEmp
        [HttpPost]
        public ActionResult Index(String dept,String emp_no)
        {
            ViewBag.dept = h.GetDept();
            if((!(dept is null) || dept != "0") && !(emp_no is null))
            {
                h.DelEmp(emp_no);
                ViewBag.select = dept;
                return View(h.GetEmp(dept));
            }
            else if ((!(dept is null) || dept != "0") && emp_no is null)
            {
                ViewBag.select = dept;
                return View(h.GetEmp(dept));
            }

            return View();
        }
    }
}