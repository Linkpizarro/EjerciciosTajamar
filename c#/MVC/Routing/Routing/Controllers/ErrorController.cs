using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    public class ErrorController : Controller
    {
        // GET: NotFound
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            ViewBag.Error = "Lo sentimos, pero la página solicitada no existe.";
            return View();
        }

        // GET: Error
        public ActionResult Error()
        {
            ViewBag.Error = "Se ha producido un error";
            return View();
        }
    }
}