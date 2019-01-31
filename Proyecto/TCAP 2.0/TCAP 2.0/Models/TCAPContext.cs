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

        public TCAPContext() : base("name=TCAPString") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Pub> Pubs { get; set; }
    }
}