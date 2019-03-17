using ApiEmpleadosSeguridadCore.Data;
using ApiEmpleadosSeguridadCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmpleadosSeguridadCore.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }

        public Empleado BuscarEmpleado(int empno)
        {
            return this.context.Empleados
                .SingleOrDefault(x => x.IdEmpleado == empno);
        }

        public List<Empleado> GetEmpleadosSubordinados(int director)
        {
            var consulta = from datos in context.Empleados
                           where datos.Director == director
                           select datos;
            return consulta.ToList();
        }

        public Empleado ExisteEmpleado(String apellido
            , int empno)
        {
            var consulta = from datos in context.Empleados
                           where datos.Apellido == apellido
                           && datos.IdEmpleado == empno
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
