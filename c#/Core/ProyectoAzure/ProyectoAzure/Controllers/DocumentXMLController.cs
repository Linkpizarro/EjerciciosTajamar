using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Clientes()
        {
            String filename = "clientes.xml";
            XDocument docxml = XDocument.Load(pathprivider.MapPath(filename, Folders.Documents));

            var clientes = from data in docxml.Descendants("cliente")
                           select new Cliente
                           {
                               Nombre = data.Element("nombre").Value,
                               Direccion = data.Element("direccion").Value,
                               Imagen = data.Element("imagen_cliente").Value
                           };


            return View(clientes);
        }
        public IActionResult AddCliente()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCliente(int id,String nombre,String direccion,IFormFile imagen)
        {
            String filename = "clientes.xml";
            XDocument docxml = XDocument.Load(pathprivider.MapPath(filename, Folders.Documents));
            XElement cliente = new XElement("cliente");
            cliente.Add(new XAttribute("idcliente", id));
            cliente.Add(new XElement("nombre",nombre));
            cliente.Add(new XElement("direccion", direccion));
            cliente.Add(new XElement("imagen_cliente", imagen.FileName));

            docxml.Element("clientes").Add(cliente);
            docxml.Save(pathprivider.MapPath(filename, Folders.Documents));

            String src = null;
            src = pathprivider.MapPath(imagen.FileName, Folders.Clientes);

            using (var stream = new FileStream(src, FileMode.Create))
            {
                await imagen.CopyToAsync(stream);
            }

            return RedirectToAction("Clientes","DocumentXML");
        }


    }
}