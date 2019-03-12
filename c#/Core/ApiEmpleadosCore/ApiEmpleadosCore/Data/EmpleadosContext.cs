using ApiEmpleadosCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmpleadosCore.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
