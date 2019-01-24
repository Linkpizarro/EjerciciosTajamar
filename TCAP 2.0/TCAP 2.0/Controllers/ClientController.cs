using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Attribute;
using TCAP_2._0.Interfaces;

namespace TCAP_2._0.Controllers
{
    [AuthorizeClient]
    public class ClientController : Controller
    {
        IRepositoryClient repo;
        public ClientController(IRepositoryClient repo)
        {
            this.repo = repo;
        }
        // GET: Client
        public ActionResult Index()
        {
            Session["Client"] = repo.GetDataClient(int.Parse(HttpContext.User.Identity.Name));
            return View();
        }
    }
}