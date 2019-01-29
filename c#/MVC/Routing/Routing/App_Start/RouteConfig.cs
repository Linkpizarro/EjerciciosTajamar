using Routing.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            List<String> Ban = new List<String>();
            Ban.Add("Pamplona");
            Ban.Add("Barcelona");
            Ban.Add("Salamanca");
            Ban.Add("Murcia");

            RouteTable.Routes.Add("WikiProvinces",
                new Route("Provinces/{ProvinceName}",
                    new RouteWiki(Ban)));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
