using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HospitalContextMySql : DbContext
    {
        public HospitalContextMySql() : base("name=CadenaHospitalMySql") { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}