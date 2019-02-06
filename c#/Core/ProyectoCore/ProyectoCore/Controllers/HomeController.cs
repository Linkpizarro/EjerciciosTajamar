using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProyectoCore.Controllers
{
    public class HomeController : Controller
    {
        ILogger log;
        public HomeController(ILogger<HomeController> log)
        {
            this.log = log;
        }
        public IActionResult Index()
        {
            log.LogInformation("Estás en index");
            return View();
        }

        public IActionResult About(String usuario)
        {
            log.LogInformation("Estás en ABOUT");
            ViewData["Saludo"] = "Muy buenas " + usuario;
            return View();
        }
    }
}