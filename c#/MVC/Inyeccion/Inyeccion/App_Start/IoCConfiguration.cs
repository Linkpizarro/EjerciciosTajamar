using Autofac;
using Autofac.Integration.Mvc;
using Inyeccion.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inyeccion.App_Start
{
    public class IoCConfiguration
    {
        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterModule(new IoCModule());
            IoCModule.RegistrarRepositorios(builder);
            IContainer contenedor = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contenedor));

        }
    }
}