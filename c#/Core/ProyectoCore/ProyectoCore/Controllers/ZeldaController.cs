using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoCore.Areas.Zelda.Controllers
{
    [Area("Zelda")]
    public class ZeldaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}