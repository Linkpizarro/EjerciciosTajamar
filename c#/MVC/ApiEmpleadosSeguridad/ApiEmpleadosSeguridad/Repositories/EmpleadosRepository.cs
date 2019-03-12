using ApiEmpleadosSeguridad.Data;
using ApiEmpleadosSeguridad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiEmpleadosSeguridad.Repositories
{
    public class EmpleadosRepository
    {
        EmpleadoContext context;
        public EmpleadosRepository()
        {
            this.context = new EmpleadoContext();
        }

        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }
        public Empleado GetEmpleado(int id)
        {
            return context.Empleados.SingleOrDefault(e => e.Id == id);
        }

        public List<Empleado> GetSubs(int dir)
        {
            return context.Empleados.Where(e => e.Dir == dir).ToList();
        }

        public Empleado ExistEmpleado(String surname,int id)
        {
            return context.Empleados.SingleOrDefault(e => e.Id == id && e.Surname == surname);
        }
    }
}