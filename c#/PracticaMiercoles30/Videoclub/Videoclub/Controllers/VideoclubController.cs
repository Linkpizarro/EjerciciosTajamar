using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoclub.Attributes;
using Videoclub.Models;
using Videoclub.Repositories;

namespace Videoclub.Controllers
{
    public class VideoclubController : Controller
    {
        RepositoryVideoclub repo = new RepositoryVideoclub();


        //GET:Peliculas
        public ActionResult Peliculas(int idGenero = 0)
        {
            if(TempData["Success"] != null)
            {
                ViewBag.Success = TempData["Success"].ToString();
            }
            return View(repo.GetPeliculas(idGenero));
        }

        //GET: Detalles
        public ActionResult Detalles(int id)
        {
            if (Session["Compras"] != null)
            {
                ViewBag.Compras = Session["Compras"] as List<int>;
            }
            else
            {
                ViewBag.Compras = null;
            }
            return View(repo.GetDetallePelicula(id));
        }

        //GET: Comprar
        public ActionResult Comprar(int idPelicula)
        {
            List<int> compras;
            if (Session["Compras"] != null)
            {
                compras = Session["Compras"] as List<int>;
                compras.Add(idPelicula);
                Session["Compras"] = compras;
            }
            else
            {
                compras = new List<int>();
                compras.Add(idPelicula);
                Session["Compras"] = compras;
            }
            TempData["Success"] = "Has añadido una película al carrito";
            return RedirectToAction("Peliculas", "Videoclub");
        }

        //GET: Eliminar
        public ActionResult Eliminar(int idPelicula)
        {
            List<int> compras;
            if (Session["Compras"] != null)
            {
                compras = Session["Compras"] as List<int>;
                compras.Remove(idPelicula);
                Session["Compras"] = compras;
            }

            return RedirectToAction("VerCarrito", "Videoclub");
        }

        //GET : VerCarrito
        public ActionResult VerCarrito()
        {
            List<int> compras;
            if (Session["Compras"] != null)
            {
                compras = Session["Compras"] as List<int>;
            }
            else
            {
                compras = new List<int>();
            }

            return View(repo.GetCompras(compras));
        }

        //GET : FinalizarCompra
        [AuthorizeCliente]
        public ActionResult FinalizarCompra()
        {
            List<Pelicula> compras = repo.GetCompras(Session["Compras"] as List<int>);
            repo.InsertPedido(compras);
            Session["Compras"] = null;
            return RedirectToAction("Pedidos", "User");
        }

        // GET: Menú
        [ChildActionOnly]
        public ActionResult _Menu()
        {
            if(Session["Compras"] != null)
            {
                ViewBag.NCompras = ((List<int>)Session["Compras"]).Count;
            }
            else
            {
                ViewBag.NCompras = 0;
            }
            return PartialView(repo.GetGeneros());
        }
    }
}