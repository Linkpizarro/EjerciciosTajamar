using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace SeguridadPlantilla
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        public void Application_PostAuthenticateRequest()
        {
            HttpCookie cookie = Request.Cookies["TicketEmpleado"];
            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                GenericIdentity identidad = new GenericIdentity(ticket.Name);
                GenericPrincipal emp = new GenericPrincipal(identidad, null);
                HttpContext.Current.User = emp;
            }
        }
    }
}
