using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAProject.Attribute;
using TCAProject.Interfaces;
using TCAProject.Models.Class;

namespace TCAProject.Controllers
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
            Client client = repo.GetClient(int.Parse(HttpContext.User.Identity.Name));
            Session["Client"] = client;
            return View(repo.GetPubs(client.Id_Client));
        }

        //GET: CreatePub
        public ActionResult CreatePub()
        {
            return View();
        }

        //POST: CreatePub
        [HttpPost]
        public ActionResult CreatePub(Pub pub)
        {
            return View();
        }

    }
}