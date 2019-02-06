using Microsoft.EntityFrameworkCore;
using ProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Data
{
    public class Hospital : DbContext,IHospitalContext
    {
        public Hospital(DbContextOptions options) : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
