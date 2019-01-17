using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Models
{
    public class HospitalContextOracle : DbContext
    {
        public HospitalContextOracle() : base("name=CadenaHospitalOracle") { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}