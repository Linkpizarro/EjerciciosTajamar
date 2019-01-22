using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SeguridadEmpleados.Attributes
{
    public class AutorizacionEmpleadosAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                GenericPrincipal usuario = filterContext.HttpContext.User as GenericPrincipal;
                if (!(usuario.IsInRole("DIRECTOR")) && !(usuario.IsInRole("PRESIDENTE")))
                {
                    filterContext.Result = GetRutaRedirect("Validacion", "ErrorAcceso");
                }
            }
            else
            {
                filterContext.Result = GetRutaRedirect("Validacion", "Login");
                
            }
        }

        public static RedirectToRouteResult GetRutaRedirect(String controlador,String accion)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new { Controller = controlador, Action = accion });
            RedirectToRouteResult direccion = new RedirectToRouteResult(ruta);
            return direccion;
        }
    }
}