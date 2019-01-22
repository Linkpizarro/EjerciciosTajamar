using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeguridadEmpleados.Models
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext() : base("name=EmpleadoString") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}