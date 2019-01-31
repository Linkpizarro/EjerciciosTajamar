using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using TCAP_2._0.App_Start;

namespace TCAP_2._0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            IoCConfiguration.Configure();
        }

        public void Application_PostAuthenticateRequest()
        {
            HttpCookie cookie = Request.Cookies["TicketUser"];
            if (cookie != null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(cookie.Value);
                GenericIdentity identity = new GenericIdentity(ticket.Name);
                GenericPrincipal user = new GenericPrincipal(identity, new String[] { ticket.UserData });
                HttpContext.Current.User = user;
            }
        }
    }
}
