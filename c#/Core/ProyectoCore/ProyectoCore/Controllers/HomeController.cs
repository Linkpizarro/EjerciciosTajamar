using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoCore.Extensions;

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
            String text = "Hoy es Jueves";
            ViewData["Num"] = text.GetNumWords();

            log.LogInformation("Estás en ABOUT");
            ViewData["Saludo"] = "Muy buenas " + usuario;
            return View();
        }
        //GET:Donativos
        public IActionResult Donativos()
        {
            return View();
        }
        //POST:Donativos
        [HttpPost]
        public IActionResult Donativos(String name, int priece)
        {
            ViewData["Message"] = name + " Ha donado una cantidad de " + priece + "€";
            //Trace
            Trace.TraceInformation(name + " " + priece + "€");
            //Metric
            MetricTelemetry metric = new MetricTelemetry();
            metric.Name = "Donor";
            metric.Sum = priece;
            //Event
            TelemetryClient client = new TelemetryClient();
            client.TrackEvent("Donor Event");
            client.TrackMetric(metric);
            return View();
        }

        public IActionResult MySesion(String accion)
        {
            if (accion == null || accion == "guardar")
            {
                ViewData["Message"] = "Guardando sesión";
                HttpContext.Session.SetString("Name", "Daniel");
                HttpContext.Session.SetInt32("Year", 23);         
            }
            else
            {
                ViewData["Message"] = "Almacenando sesión";
                ViewData["Name"] = HttpContext.Session.GetString("Name");
                ViewData["Year"] = HttpContext.Session.GetInt32("Year");
            }
            return View();
        }
    }
}