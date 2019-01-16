using Autofac;
using Autofac.Integration.Mvc;
using InyeccionEntity.Models;
using InyeccionEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace InyeccionEntity.App_Start
{
    public class IoCConfiguration
    {
        private static void RegistrarControladores(ContainerBuilder builder) {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
        }

        private static void RegistrarRepositorios(ContainerBuilder builder) {
            builder.RegisterType<RepositoryHospital>().As<IRepositoryHospital>().InstancePerRequest();
            builder.RegisterType<RepositoryDepartamento>().As<IRepositoryDepartamento>().InstancePerRequest();
        }

        private static void RegistrarClases(ContainerBuilder builder)
        {
            builder.Register(z => new HospitalContext()).InstancePerRequest();
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