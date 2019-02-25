using AzureMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace AzureMVC.Controllers
{
    public class CatastroController : Controller
    {
        ServicioCatastro.CallejerodelasedeelectrónicadelcatastroSoapClient cliente;
        public CatastroController()
        {
            this.cliente = new ServicioCatastro.CallejerodelasedeelectrónicadelcatastroSoapClient();
        }
        // GET: Catastro
        public ActionResult Provincias()
        {
            XmlNode nodo = cliente.ObtenerProvincias();
            String datos = nodo.OuterXml;
            XDocument doc = XDocument.Parse(datos);
            XNamespace ns = "http://www.catastro.meh.es/";
            var consulta = from data in doc.Descendants(ns + "prov")
                           select new Provincia
                           {
                               Codigo = int.Parse(data.Element(ns + "cpine").Value),
                               Nombre = data.Element(ns + "np").Value
                           };
            List<Provincia> provincias = consulta.ToList();

            return View(provincias);
        }
    }
}