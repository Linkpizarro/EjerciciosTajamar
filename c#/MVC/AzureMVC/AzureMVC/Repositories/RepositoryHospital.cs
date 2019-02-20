using AzureMVC.Data;
using AzureMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureMVC.Repositories
{
    public class RepositoryHospital
    {
        Context context;
        public RepositoryHospital(Context context)
        {
            this.context = context;
        }
        public List<Enfermo> GetEnfermos()
        {
            return context.GetEnfermos().ToList();
        }
        public int EliminarEnfermo(int inscripcion)
        {
            return context.EliminarEnfermo(inscripcion);
        }
    }
}