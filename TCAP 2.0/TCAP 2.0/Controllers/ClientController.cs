using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Attribute;

namespace TCAP_2._0.Controllers
{
    [AuthorizeClient]
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
    }
}