using CodeFirstAzure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirstAzure.Data
{
    public class LibraryContext :DbContext
    {
        public LibraryContext() : base("name=Cadena") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}