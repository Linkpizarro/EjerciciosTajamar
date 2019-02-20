using ProyectoAzure.Data;
using ProyectoAzure.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Repositories
{
    public class RepositoryEnfermo:IRepositoryEnfermo
    {
        IHospitalContext context;
        public RepositoryEnfermo(IHospitalContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos() {
            return context.GetEnfermos();
        }

        public int EliminarEnfermo(int inscripcion) {
            return context.EliminarEnfermo(inscripcion);
        }
    }
}
