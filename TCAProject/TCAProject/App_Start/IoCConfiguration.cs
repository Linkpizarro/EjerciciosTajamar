using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TCAProject.Interfaces;
using TCAProject.Models;
using TCAProject.Repositories;

namespace TCAProject.App_Start
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
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>().InstancePerRequest();
            builder.RegisterType<RepositoryPlayer>().As<IRepositoryPlayer>().InstancePerRequest();
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