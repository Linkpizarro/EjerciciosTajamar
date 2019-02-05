using Microsoft.EntityFrameworkCore;
using ProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
