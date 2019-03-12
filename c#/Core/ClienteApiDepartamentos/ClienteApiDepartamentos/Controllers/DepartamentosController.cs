using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiDepartamentos.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartamentosCliente()
        {
            return View();
        }
    }
}