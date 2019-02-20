using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoAzure.Models;

namespace ProyectoAzure.Data
{
    public class HospitalContext : DbContext, IHospitalContext
    {
       
        public HospitalContext(DbContextOptions options):base(options)
        {}

        public DbSet<Enfermo> Enfermos { get; set; }
        public List<Enfermo> GetEnfermos() {
            String sql = "SHOWSICK";
            return Enfermos.FromSql(sql).ToList();
        }
        public int EliminarEnfermo(int inscripcion)
        {
            String sql = "DELETESTICK @INSCRIPCION";
            SqlParameter parameter = new SqlParameter("@INSCRIPCION", inscripcion);
            int afectados = Database.ExecuteSqlCommand(sql, parameter);
            return afectados;
        }
    }
}
