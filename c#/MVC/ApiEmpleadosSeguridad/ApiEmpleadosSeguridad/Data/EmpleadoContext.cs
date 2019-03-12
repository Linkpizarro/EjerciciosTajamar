using ApiEmpleadosSeguridad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiEmpleadosSeguridad.Data
{
    public class EmpleadoContext :DbContext
    {
        public EmpleadoContext() : base("name=cadena") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpleadoContext>(null);
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}