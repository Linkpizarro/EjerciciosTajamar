using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace Security
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
            HttpCookie cookie = Request.Cookies["TicketUsuario"];
            if (cookie != null)
            {
                String datosCifrados = cookie.Value;
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(datosCifrados);
                String username = ticket.Name;
                String userrole = ticket.UserData;
                GenericIdentity identidad = new GenericIdentity(username);
                GenericPrincipal user = new GenericPrincipal(identidad, new String[] { userrole });
                HttpContext.Current.User = user;
            }
        }
    }
}
