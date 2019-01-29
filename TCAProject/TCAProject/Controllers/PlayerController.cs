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
    [AuthorizePlayer]
    public class PlayerController : Controller
    {
        IRepositoryPlayer repo;

        public PlayerController(IRepositoryPlayer repo)
        {
            this.repo = repo;
        }

        // GET: Parties
        public ActionResult Parties()
        {
            Player player = repo.GetPlayer(int.Parse(HttpContext.User.Identity.Name));
            Session["Player"] = player;
            return View(repo.GetParties(player.Id_Player));
        }

        //GET: CreateParty
        public ActionResult CreateParty()
        {
            return View();
        }

        //POST: CreateParty
        [HttpPost]
        public ActionResult CreateParty(Party party)
        {
            return View();
        }

    }
}