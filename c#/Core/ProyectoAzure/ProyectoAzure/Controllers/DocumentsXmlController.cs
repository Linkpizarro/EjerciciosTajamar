using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.IO;
using ProyectoAzure.Models;
using Microsoft.AspNetCore.Hosting;
using ProyectoAzure.Providers;
using ProyectoAzure.Repositories;

namespace ProyectoAzure.Controllers
{
    public class DocumentsXmlController : Controller
    {
        IRepositoryXml repo;

        public DocumentsXmlController(IRepositoryXml repo)
        {
            this.repo = repo;
        }

        public IActionResult ListaJoyerias()
        {
            return View(this.repo.GetJoyerias());
        }
    }
}