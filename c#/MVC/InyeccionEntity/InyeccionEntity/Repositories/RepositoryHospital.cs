using InyeccionEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Models
{
    public class RepositoryHospital : IRepositoryHospital
    {
        HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }
        public List<Hospital> GetHospitales()
        {
            return context.Hospitales.ToList();
        }

    }
}