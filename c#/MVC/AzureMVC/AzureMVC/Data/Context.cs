using AzureMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace AzureMVC.Data
{
    public class Context:DbContext
    {
        public Context():base("name=cadena"){}
        public DbSet<Enfermo> Enfermos { get; set; }
        public ObjectResult<Enfermo> GetEnfermos()
        {
            IObjectContextAdapter adapter = (IObjectContextAdapter)this;
            return adapter.ObjectContext.ExecuteFunction<Enfermo>("SHOWSICK");
        }
        public int EliminarEnfermo(int inscripcion)
        {
            ObjectParameter param = new ObjectParameter("INSCRIPCION", inscripcion);
            IObjectContextAdapter adapter = (IObjectContextAdapter)this;
            return adapter.ObjectContext.ExecuteFunction("DELETESTICK",param);
        }
    }
}