using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProyectoAzure.Models;
using ProyectoAzure.Providers;

namespace ProyectoAzure.Controllers
{
    public class DocumentXMLController : Controller
    {
        PathProvider pathprivider;
        public DocumentXMLController(PathProvider pathprivider)
        {
            this.pathprivider = pathprivider;
        }

        public IActionResult Joyerias()
        {
            String filename = "joyeria.xml";
            XDocument docxml = XDocument.Load(pathprivider.MapPath(filename,Folders.Documents));

            var joyerias = from data in docxml.Descendants("joyeria")
                           select new Joyeria
                           {
                               Nombre = data.Element("nombrejoyeria").Value,
                               Direccion = data.Element("direccion").Value,
                               Telefono = data.Element("telf").Value
                           };


            return View(joyerias);
        }
    }
}