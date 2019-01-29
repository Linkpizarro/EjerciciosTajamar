using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConceptosMVC.Controllers
{
    public class RoutingController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            //ACCEDEMOS A LOS VALORES DEL ROUTING
            //MEDIANTE LA CLASE ROUTEDATA
            RouteValueDictionary valoresruta = RouteData.Values;

            String html = "<p>";

            //RECORREMOS TODOS LOS VALORES QUE CONTIENE
            //LA RUTA, Y LOS EXTRAEMOS MEDIANTE KEY-VALUE
            foreach (String key in valoresruta.Keys)
            {
                String valor = valoresruta[key].ToString();
                html += "<p><b>" + key + ": </b>" + valor + "</p>";
            }
            //AHORA VAMOS A UTILIZAR EL OBJETO HTMLSTRING
            //QUE NOS PERMITE ENVIAR UNA CADENA FORMATEADA DIRECTAMENTE
            //EN EL VIEWBAG PARA QUE SEA TRADUCIDA POR EL EXPLORADOR WEB
            MvcHtmlString htmlstring = new MvcHtmlString(html);

            //ALMACENAMOS EL VALOR EN EL VIEWBAG
            ViewBag.Rutas = htmlstring;

            return View();
        }

        public ActionResult Buscar()
        {
            //RECUPERAMOS LOS VALORES TIPOACCION Y IDDATO

            String tipoaccion = RouteData.Values["tipoaccion"].ToString();
            String iddato = RouteData.Values["iddato"].ToString();

            String resultado = String.Empty;

            switch (tipoaccion.ToLower())
            {
                case "peliculas":
                    {
                        switch (iddato.ToLower())
                        {
                            case "regreso al futuro":
                                {
                                    resultado = "Disponibles 5";
                                    break;
                                }
                            case "avatar":
                                {
                                    resultado = "Disponible 7";
                                    break;
                                }
                            default:
                                {
                                    resultado = "La película " + iddato + " no existe en stock";
                                    break;
                                }
                        }
                        break;
                    }
                case "comics":
                    {
                        switch (iddato.ToLower())
                        {
                            case "batman":
                                {
                                    resultado = "Disponibles 4 unidades.";
                                    break;
                                }
                            case "lobezno":
                                {
                                    resultado = "Disponibles 12 unidades.";
                                    break;
                                }
                            default:
                                {
                                    resultado = String.Format("El comic " + iddato + " no existe en stock");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }
            //DEVOLVEMOS UN CONTENIDO HTML PARA VISUALIZAR LOS 
            //RESULTADOS DE LA PETICION
            return Content("<h2 style='color:blueviolet'>" + resultado + "</h2>");
        }

    }
}