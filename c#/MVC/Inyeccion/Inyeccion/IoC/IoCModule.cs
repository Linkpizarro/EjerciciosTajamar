using Autofac;
using Inyeccion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inyeccion.IoC
{
    public class IoCModule : Module
    {
        //protected override void Load(ContainerBuilder builder)
        //{
        //    builder.Register(z => new RepositoryProductos()).SingleInstance();
        //    base.Load(builder);
        //}

        public static void RegistrarRepositorios(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryProductos>().As<IRepositoryProductos>().InstancePerRequest();
        }
    }
}