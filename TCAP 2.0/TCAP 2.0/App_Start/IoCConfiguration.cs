using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models;
using TCAP_2._0.Repositories;

namespace TCAP_2._0.App_Start
{
    public class IoCConfiguration
    {
        private static void RegistrarControladores(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
        }

        private static void RegistrarRepositorios(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryAccount>().As<IRepositoryAccount>().InstancePerRequest();
        }

        private static void RegistrarClases(ContainerBuilder builder)
        {
            builder.Register(z => new TCAPContext()).InstancePerRequest();
        }

        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            RegistrarControladores(builder);
            RegistrarRepositorios(builder);
            RegistrarClases(builder);
            IContainer contenedor = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contenedor));
        }
    }
}