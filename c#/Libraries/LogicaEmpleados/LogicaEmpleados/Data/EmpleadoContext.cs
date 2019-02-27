using LogicaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmpleados.Data
{
    public class EmpleadoContext:DbContext
    {
        public EmpleadoContext() : base("name=CadenaHospital") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
