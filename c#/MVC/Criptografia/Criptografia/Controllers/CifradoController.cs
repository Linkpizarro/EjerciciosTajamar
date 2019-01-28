using Criptografia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Criptografia.Controllers
{
    public class CifradoController : Controller
    {
        RepositoryCifrado repo = new RepositoryCifrado();
        // GET: Cifrado
        public ActionResult Cifrar()
        {
            return View();
        }
        // POST: Cifrado
        [HttpPost]
        public ActionResult Cifrar(String texto,String publica,String privada,String archivo)
        {
            String rute = Server.MapPath("~/Files");
            String path = Path.Combine(rute,archivo+".txt");
            repo.CifrarArchivo(texto, publica, privada, path);
            Session["Publica"] = publica;
            return RedirectToAction("DesCifrar", "Cifrado");
        }
        // GET: DesCifrado
        public ActionResult DesCifrar()
        {
            return View();
        }
        // POST: DesCifrado
        [HttpPost]
        public ActionResult DesCifrar(String privada,String archivo)
        {
            String rute = Server.MapPath("~/Files");
            String path = Path.Combine(rute, archivo + ".txt");
            ViewBag.Text = repo.DecifrarArchivo(Session["Publica"].ToString(), privada, path);
            return View();
        }
    }
}