﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SeguridadPlantilla.Attributes
{
    public class AuthorizeEmpAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {

            }
            else
            {
                filterContext.Result = GetRutaRedirect("Validation", "Login");

            }
        }

        public static RedirectToRouteResult GetRutaRedirect(String controlador, String accion)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new { Controller = controlador, Action = accion });
            RedirectToRouteResult direccion = new RedirectToRouteResult(ruta);
            return direccion;
        }
    }
}
