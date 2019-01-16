using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Models
{
    public class HospitalContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HospitalContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public HospitalContext() :base("name=CadenaHospital"){}

        public DbSet<Hospital> Hospitales { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

    }
}