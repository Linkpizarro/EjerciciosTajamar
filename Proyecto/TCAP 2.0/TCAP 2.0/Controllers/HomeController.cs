using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCAP_2._0.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }


        // GET: _Header
        [ChildActionOnly]
        public ActionResult _Header()
        {
            if (Session["User"] != null)
            {
                return PartialView(Session["User"]);
            }
            return PartialView(null);
        }
    }
}