using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCAProject.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Error()
        {
            return View();
        }

        // GET: NotFound
        public ActionResult NotFound()
        {
            return View();
        }

        // GET: TimeOut
        public ActionResult TimeOut()
        {
            return View();
        }
    }
}