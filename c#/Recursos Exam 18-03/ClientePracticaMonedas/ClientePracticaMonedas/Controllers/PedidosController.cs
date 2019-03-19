using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientePracticaMonedas.Models;
using ClientePracticaMonedas.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientePracticaMonedas.Controllers
{
    public class PedidosController : Controller
    {
        PedidosRepository repo;
        public PedidosController(PedidosRepository repo)
        {
            this.repo = repo;
        }

        //Muestra los Pedidos del Cliente
        public async Task<IActionResult> Index()
        {
            String token = HttpContext.Session.GetString("token");
            int id = int.Parse(HttpContext.User.Identity.Name);
            List<Pedido> pedidos = await this.repo.GetPedidos(id,token);
            return View(pedidos);
        }

        //Realizamos una compra.
        public async Task<IActionResult> Comprar(int id_moneda)
        {
            String token = HttpContext.Session.GetString("token");
            int id = int.Parse(HttpContext.User.Identity.Name);
            Pedido pedido = new Pedido(){
                Cliente_Id = id,
                Moneda_Id = id_moneda,
                Unidades = 1,
                Fecha = DateTime.Now
            };

            await this.repo.PostPedido(pedido, token);
            return RedirectToAction("Index", "Pedidos");
        }

        public async Task<IActionResult> Eliminar (int id)
        {
            String token = HttpContext.Session.GetString("token");
            await this.repo.DeletePedido(id, token);
            return RedirectToAction("Index", "Pedidos");
        }
    }
}