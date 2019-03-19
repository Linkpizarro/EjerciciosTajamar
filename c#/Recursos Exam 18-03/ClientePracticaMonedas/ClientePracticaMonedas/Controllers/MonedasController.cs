using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientePracticaMonedas.Models;
using ClientePracticaMonedas.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClientePracticaMonedas.Controllers
{
    public class MonedasController : Controller
    {
        MonedasRepository repo;
        public MonedasController(MonedasRepository repo)
        {
            this.repo = repo;
        }

        //Muestra todas las Monedas.
        public async Task<IActionResult> Index()
        {
            List<Moneda> monedas = await this.repo.GetMonedas();
            return View(monedas);
        }
        public async Task<IActionResult> Detalles(int id)
        {
            Moneda moneda = await this.repo.GetMoneda(id);
            return View(moneda);
        }
    }
}