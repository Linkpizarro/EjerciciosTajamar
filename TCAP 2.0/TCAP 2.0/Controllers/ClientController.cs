using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Attribute;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models.Class;

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
        // GET: Pubs
        public ActionResult Pubs()
        {
            Client client = repo.GetDataClient(int.Parse(HttpContext.User.Identity.Name));
            Session["Client"] = client;
            return View(repo.GetPubs(client.Id_Client));
        }
    }
}