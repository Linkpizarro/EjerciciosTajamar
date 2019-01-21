using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Security.Attributes
{
    public class AutorizacionUsersAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (filterContext.HttpContext.User.IsInRole("Administrador"))
                {
    
                }
                else
                {
                    RouteValueDictionary ruta = new RouteValueDictionary(
                        new{
                            Controller = "Validacion",
                            Action = "ErrorAcceso"
                        }
                    );
                    RedirectToRouteResult direccion = new RedirectToRouteResult(ruta);
                    filterContext.Result = direccion;
                }
            }
            else
            {
                RouteValueDictionary ruta = new RouteValueDictionary(
               new
               {
                   Controller = "Validacion",
                   Action = "Login"
               }
            );
                RedirectToRouteResult direccion = new RedirectToRouteResult(ruta);
                filterContext.Result = direccion;
            }
           

        }
    }
}