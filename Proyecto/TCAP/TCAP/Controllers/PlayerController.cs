using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP.Models;
using TCAP.Models.Helpers;

namespace TCAP.Controllers
{
    public class PlayerController : Controller
    {
        HelperPlayer h = new HelperPlayer();
        // GET: Home
        public ActionResult Home()
        {
            if (!(TempData["Player"] is null))
            {
                h.StartSession(((USERS)TempData["Player"]).TOKEN_SESSION);
            }
            
            return View();
        }
    }
}