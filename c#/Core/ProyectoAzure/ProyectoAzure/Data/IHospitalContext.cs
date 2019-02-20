using Microsoft.EntityFrameworkCore;
using ProyectoAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Data
{
    public interface IHospitalContext
    {
        DbSet<Enfermo> Enfermos{ get; set; }
        List<Enfermo> GetEnfermos();
        int EliminarEnfermo(int inscripcion);
    }
}
