using Routing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            Exception ex = Server.GetLastError();
            HttpException exhttp = ex as HttpException;
            String action = "";
            Context.ClearError();
            if(exhttp.GetHttpCode() == 404)
            {
                action = "NotFound";
            }
            else
            {
                action = "Error";
            }
            RouteData rute = new RouteData();
            rute.Values.Add("controller", "Error");
            rute.Values.Add("action", action);
            IController controller = new ErrorController();
            controller.Execute(new RequestContext(new HttpContextWrapper(Context),rute));
        }
    }
}
