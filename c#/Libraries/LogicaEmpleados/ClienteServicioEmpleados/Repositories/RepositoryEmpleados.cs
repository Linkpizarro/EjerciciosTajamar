using ClienteServicioEmpleados.ServiceEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteServicioEmpleados.Repositories
{
    public class RepositoryEmpleados
    {
        ServiceEmpleadosClient service;
        public RepositoryEmpleados()
        {
            this.service = new ServiceEmpleadosClient();
        }

        public List<String> GetOficios()
        {
            return service.GetOficios().ToList();
        }
        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            return service.GetEmpleadosOficio(oficio).ToList();
        }
    }
}