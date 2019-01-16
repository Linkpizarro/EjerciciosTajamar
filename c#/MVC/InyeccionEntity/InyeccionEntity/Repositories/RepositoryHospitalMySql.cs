using InyeccionEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Repositories
{
    public class RepositoryHospitalMySql : IRepositoryHospital
        {
            HospitalContextMySql context;
            public RepositoryHospitalMySql(HospitalContextMySql context)
            {
                this.context = context;
            }
            public List<Hospital> GetHospitales()
            {
                return context.Hospitales.ToList();
            }
        }
}