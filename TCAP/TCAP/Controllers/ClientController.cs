﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP.Models;

namespace TCAP.Controllers
{
    public class ClientController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View(TempData["Client"]);
        }
    }
}