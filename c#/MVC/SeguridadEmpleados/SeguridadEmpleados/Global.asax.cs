using SeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace SeguridadEmpleados
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object Genericidentity { get; private set; }

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

                //String[] roles = new string[] { ticket.UserData };
                String username = ticket.Name;
                int emp_no = int.Parse(ticket.UserData);

                GenericIdentity identidad = new GenericIdentity(username);
                //GenericPrincipal usuario = new GenericPrincipal(identidad, roles);
                RepositoryEmpleados repo = new RepositoryEmpleados();
                Empleado empleado = repo.BuscarEmpleado(emp_no);
                HttpContext.Current.User = empleado; 
            }
        }
    }
}
