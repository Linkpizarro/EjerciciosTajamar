﻿using MVCEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemplo1.Controllers
{
    public class InfoController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: Business 
        public ActionResult Business()
        {
            Connect n = new Connect();
            return View(n.GetData("GETEMPRESAS", "Empresa"));
        }
        //GET: BusinessInfo
        public ActionResult BusinessInfo(String id)
        {
            Connect n = new Connect();
            Client c = n.GetCliente("GETCLIENTE",id);
            return View(c);
        }
        //POST: UpdateBussiness
        [HttpPost]
        public ActionResult UpdateBussiness(String id,String emp,String cont,String car,String ciu,String tel)
        {
            Connect n = new Connect();
            n.ModificarCliente("MODIFICARCLIENTE", id,emp,car,cont,ciu,tel);
            return View();
        }


    }
}