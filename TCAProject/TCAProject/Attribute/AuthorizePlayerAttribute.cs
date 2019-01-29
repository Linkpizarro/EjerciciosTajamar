using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TCAProject.Attribute
{
    public class AuthorizePlayerAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                GenericPrincipal user = filterContext.HttpContext.User as GenericPrincipal;
                if (!(user.IsInRole("2")))
                {
                    filterContext.Result = GetRuteRedirect("Error", "NotFound");
                }
            }
            else
            {
                filterContext.Result = GetRuteRedirect("Account", "Login");

            }
        }

        public static RedirectToRouteResult GetRuteRedirect(String controlador, String accion)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new { Controller = controlador, Action = accion });
            RedirectToRouteResult direccion = new RedirectToRouteResult(ruta);
            return direccion;
        }
    }
}