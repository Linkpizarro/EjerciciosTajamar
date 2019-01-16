using InyeccionEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Repositories
{
    public class RepositoryDepartamentoMySql : IRepositoryDepartamento
    {
        HospitalContextMySql context;
        public RepositoryDepartamentoMySql(HospitalContextMySql context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }
    }
}