using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Videoclub.Models
{
    public class VideoclubContext : DbContext
    {
        //Codigo de inicialización.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VideoclubContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public VideoclubContext() : base("name=PeliculasString") { }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}