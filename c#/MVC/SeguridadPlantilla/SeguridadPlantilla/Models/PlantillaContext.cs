using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeguridadPlantilla.Models
{
    public class PlantillaContext : DbContext
    {
        public PlantillaContext():base("name=PlantillaString"){}
        public DbSet<Plantilla> Empleados { get; set; }
    }
}