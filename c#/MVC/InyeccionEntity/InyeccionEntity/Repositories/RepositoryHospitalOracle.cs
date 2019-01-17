using InyeccionEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Repositories
{
    public class RepositoryHospitalOracle : IRepositoryHospital
    {
        HospitalContextOracle context;
        public RepositoryHospitalOracle(HospitalContextOracle context)
        {
            this.context = context;
        }
        public List<Hospital> GetHospitales()
        {
            return context.Hospitales.ToList();
        }
    }
}