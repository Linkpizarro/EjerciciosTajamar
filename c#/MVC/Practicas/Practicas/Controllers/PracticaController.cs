using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practicas.Models;

namespace Practicas.Controllers
{
    public class PracticaController : Controller
    {
        Practica p = new Practica();

        // GET: Practica
        public ActionResult Index()
        {
            return View();
        }

        // GET: Suma
        public ActionResult Suma()
        {
            return View();
        }
        // POST: Suma
        [HttpPost]
        public ActionResult Suma(int? n1,int? n2)
        {
            ViewBag.Total = p.GetSuma(n1, n2);
            return View();
        }

        // GET: EnlacesRandom
        public ActionResult EnlacesRandom(int? num)
        { 
            ViewBag.Res = p.GetDoble(num);
            return View();
        }

        // GET: TablaMultiplicar
        public ActionResult TablaMultiplicar()
        {
            return View();
        }
        // POST: TablaMultiplicar
        [HttpPost]
        public ActionResult TablaMultiplicar(int? num)
        {
            ViewBag.Num = p.NoNull(num);
            ViewBag.NumList = p.GetTablaMultiplicar(p.NoNull(num));
            return View();
        }

        // GET: TablaMultiplicarObjeto
        public ActionResult TablaMultiplicarObjeto()
        {
            return View();
        }
        // POST: TablaMultiplicarObjeto
        [HttpPost]
        public ActionResult TablaMultiplicarObjeto(int? num)
        {
            ViewBag.Num = p.NoNull(num);
            ViewBag.NumList = p.GetTablaMultiplicarObjeto(p.NoNull(num));
            return View();
        }

        // GET: VideoYoutube
        public ActionResult VideoYoutube()
        {
            return View();
        }
        // POST: VideoYoutube
        [HttpPost]
        public ActionResult VideoYoutube(String url)
        {
            ViewBag.Html = p.GetVideo(url);
            return View();
        }

        // GET: VideoYoutubeSelect
        public ActionResult VideoYoutubeSelect()
        {
            return View(p.CreateSelectVideo());
        }
        // POST: VideoYoutubeSelect
        [HttpPost]
        public ActionResult VideoYoutubeSelect(String url)
        {
            ViewBag.Html = p.GetVideo(url);
            return View(p.CreateSelectVideo());
        }
        
    }
}