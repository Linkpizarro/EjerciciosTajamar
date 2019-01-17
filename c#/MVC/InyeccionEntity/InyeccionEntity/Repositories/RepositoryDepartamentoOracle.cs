using InyeccionEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Repositories
{
    public class RepositoryDepartamentoOracle : IRepositoryDepartamento
    {
        HospitalContextOracle context;
        public RepositoryDepartamentoOracle(HospitalContextOracle context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }
    }
}