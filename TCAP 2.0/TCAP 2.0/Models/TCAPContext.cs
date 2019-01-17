using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Models
{
    public class TCAPContext : DbContext
    {
        //Codigo de inicialización.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<TCAPContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        //Constructor (Obtiene cadena de conexión).
        public TCAPContext() : base("name=TCAPString") { }

        //Metodo para poder registrar usuarios.
        public DbSet<User> Users { get; set; }
    }
}