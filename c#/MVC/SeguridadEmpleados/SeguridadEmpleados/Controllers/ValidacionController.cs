using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SeguridadEmpleados.Controllers
{
    public class ValidacionController : Controller
    {
        RepositoryEmpleados repo;
        public ValidacionController()
        {
            repo = new RepositoryEmpleados();
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(String apellido,int emp_no)
        {
            Empleado emp = repo.ExisteEmpleado(apellido, emp_no);

            if(emp != null)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,apellido,DateTime.Now,DateTime.Now.AddMinutes(10),true, emp_no.ToString());
                String cifrado = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie("TicketEmpleado", cifrado);
                Response.Cookies.Add(cookie);

                return RedirectToAction("Index", "Empleados");
            }
            else
            {
                ViewBag.Error = "Usuario/Número de empleado incorrectos.";
            }
            return View();
        }

        //GET: ErrorAcceso
        public ActionResult ErrorAcceso()
        {
            return View();
        }
    }
}