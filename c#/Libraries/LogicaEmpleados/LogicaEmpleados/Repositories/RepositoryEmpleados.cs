using LogicaEmpleados.Data;
using LogicaEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmpleados.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadoContext context;
        public RepositoryEmpleados()
        {
            this.context = new EmpleadoContext();
        }

        public List<String> GetOficios()
        {
            List<String> oficios = (from data in context.Empleados
                            select data.Oficio).Distinct().ToList();
            return oficios;
        }

        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            List<Empleado> empleados = (from data in context.Empleados
                                        where data.Oficio == oficio
                                        select data).ToList();
            return empleados;
        }
    }
}
