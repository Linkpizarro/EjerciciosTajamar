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
    //[AuthorizePlayer]
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
            Player player = repo.GetDataPlayer(int.Parse(HttpContext.User.Identity.Name));
            Session["User"] = player;
            return View(repo.GetDataParties(player.Id_Player));
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