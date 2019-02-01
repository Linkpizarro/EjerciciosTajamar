using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Attribute;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models.Class;
using TCAP_2._0.Models.Tools;

namespace TCAP_2._0.Controllers
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
            Player player = repo.GetDataPlayer(int.Parse(HttpContext.User.Identity.Name));
            Session["User"] = player;
            return View(repo.GetDataParties(player.Id_Player));
        }

        //GET: CreateParty
        public ActionResult CreateParty()
        {
            ViewBag.Pubs = repo.GetPubs();
            return View();
        }

        //POST: CreateParty
        [HttpPost]
        public ActionResult CreateParty(Party party,String datadate,String datatime,String pub)
        {
            DateTime datetime = DateTime.Parse(datadate + " " + datatime);
            
            //if (ModelState.IsValid){}
         
                party.Start_Party = datetime;
                party.Id_Pub = int.Parse(pub);
                repo.CreateParty(party, ((Player)Session["User"]).Id_Player);
                return RedirectToAction("Parties", "Player");
            

            //ViewBag.Pubs = repo.GetPubs();
            //return View(party);
        }

    }
}