using ProyectoCore.Data;
using ProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Repositories
{
    public class RepositoryHospital : IRepositoryHospital
    {
        IHospitalContext context;
        public RepositoryHospital(IHospitalContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }
    }
}
