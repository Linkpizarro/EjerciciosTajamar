using ProyectoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Repositories
{
    public interface IRepositoryHospital
    {
        List<Departamento> GetDepartamentos();
    }
}
