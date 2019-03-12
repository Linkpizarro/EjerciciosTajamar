using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext() : base("name=cadenahospital") { }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DepartamentosContext>(null);
        }
    }
}