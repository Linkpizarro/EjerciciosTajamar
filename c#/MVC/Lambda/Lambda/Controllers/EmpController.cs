using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lambda.Models;

namespace Lambda.Controllers
{
    public class EmpController : Controller
    {

        HelperEmp h = new HelperEmp();
        //GET : Empleados
        public ActionResult Empleados(int max = 5,int min = 0)
        {
            List<MOSTRAREMPLEADO_Result> empleados = h.GetEmp();
            List<MOSTRAREMPLEADOPAGINADO_Result> empleadosPaginado = h.GetEmpPag(max,min);
            ViewBag.Top = empleados.Count;
            ViewBag.Max = max;
            if (empleados.Count % 5 != 0)
            {
                ViewBag.Pag = (empleados.Count / 5) + 1;
            }
            else
            {
                ViewBag.Pag = empleados.Count / 5;
            }
            
            return View(empleadosPaginado);
        }

        // GET: Oficios
        public ActionResult Oficios()
        {
            ViewBag.Oficios = h.GetOficios();
            return View();
        }

        //POST: Oficios
        [HttpPost]
        public ActionResult Oficios(String oficio)
        {
            if(oficio == "")
            {
                return View();
            }

            ViewBag.Oficios = h.GetOficios();
            ViewBag.Old = oficio;
            ViewBag.Resumen = h.GetResumenOficio(oficio);
            return View(h.GetEmpOficios(oficio));
        }

        // GET: Departamentos
        public ActionResult Departamentos(String dept = null,int order = 0)
        {
            ViewBag.Depts = h.GetDepartamentos();

            if (dept == "" || dept is null)
            {
                return View();
            }

            ViewBag.Old = dept;
            ViewBag.Resumen = h.GetResumenDepartamento(dept);
            List<EMP> result = new List<EMP>();
            result = h.GetEmpDepartamento(dept);
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    result = result.OrderByDescending(x => x.DEPT_NO).ToList();
                    break;
                case 2:
                    result = result.OrderByDescending(x => x.APELLIDO).ToList();
                    break;
                case 3:
                    result = result.OrderByDescending(x => x.SALARIO).ToList();
                    break;
            }

            return View(result);
        }

        //POST: Departamentos
        [HttpPost]
        public ActionResult Departamentos(String dept)
        {
            ViewBag.Depts = h.GetDepartamentos();

            if (dept == "")
            {
                return View();
            } 

            ViewBag.Old = dept;
            ViewBag.Resumen = h.GetResumenDepartamento(dept);
            return View(h.GetEmpDepartamento(dept));
        }
    }
}