using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Data
{
    public class DepartamentoContext:DbContext
    {
        public DepartamentoContext() : base("name=CadenaHospital") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DepartamentoContext>(null);
        }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}