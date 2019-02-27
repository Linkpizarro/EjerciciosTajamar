using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaEmpleados.Models;
using LogicaEmpleados.Repositories;

namespace LogicaEmpleados.Logic
{
    public class ServiceEmpleados : IServiceEmpleados
    {
        RepositoryEmpleados repo;
        public ServiceEmpleados()
        {
            this.repo = new RepositoryEmpleados();
        }
        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            return repo.GetEmpleadosOficio(oficio);
        }

        public List<string> GetOficios()
        {
            return repo.GetOficios();
        }
    }
}
