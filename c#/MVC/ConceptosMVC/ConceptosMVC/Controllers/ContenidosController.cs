using ConceptosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptosMVC.Controllers
{
    public class ContenidosController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContenidoContent
        public ActionResult ContenidoContent()
        {
            return View();
        }

        // POST: ContenidoContent
        [HttpPost]
        public ActionResult ContenidoContent(String video)
        {
            int posicion = video.IndexOf("v=");
            String idvideo = video.Substring(posicion + 2);
            return Content("<iframe width='560' height='315' src='https://www.youtube.com/embed/" + 
                idvideo + "' frameborder='0' allowfullscreen></iframe>");
        }

        // GET: ContenidoJS
        public ActionResult ContenidoJS()
        {
            return View();
        }


        // GET: CodigoJS
        public ActionResult CodigoJS()
        {
            String imagen = Url.Content("~/Images/img2.jpg");
            String script = "$('#imagen').attr('src', '" + imagen + "');";
            return JavaScript(script);
        }

        // GET: ContenidoFile
        public ActionResult ContenidoFile()
        {
            String path = Url.Content("~/Images/img1.jpg");
            return File(path, "Image/jpeg");
        }

        // GET: ContenidoJSON
        public ActionResult ContenidoJSON()
        {
            Personaje p = new Personaje();
            p.Nombre = "Mitch";
            p.Apellido = "Buchannon";
            p.Profesion = "BayWatch";
            return Json(p, JsonRequestBehavior.AllowGet);
        }


    }
}