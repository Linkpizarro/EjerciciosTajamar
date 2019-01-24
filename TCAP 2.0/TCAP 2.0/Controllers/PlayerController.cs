using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Attribute;
using TCAP_2._0.Interfaces;

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

        // GET: Index
        public ActionResult Index()
        {
            Session["Player"] = repo.GetDataPlayer(int.Parse(HttpContext.User.Identity.Name));
            return View();
        }
    }
}