using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiSeguridadCore.Controllers
{
    public class EmpleadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}