using ProyectoAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Repositories
{
    public interface IRepositoryEnfermo
    {
        List<Enfermo> GetEnfermos();

        int EliminarEnfermo(int inscripcion);
    }
}
