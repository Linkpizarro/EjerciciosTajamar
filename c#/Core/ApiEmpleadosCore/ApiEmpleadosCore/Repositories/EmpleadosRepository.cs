using ApiEmpleadosCore.Data;
using ApiEmpleadosCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmpleadosCore.Repositories
{
    public class EmpleadosRepository
    {
        EmpleadosContext context;
        public EmpleadosRepository (EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }
        public Empleado GetEmpleado(int id)
        {
            return context.Empleados.SingleOrDefault(z => z.IdEmpleado == id);
        }
        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            return context.Empleados.Where(x => x.Salario >= salario).ToList();
        }
        public List<Empleado> GetEmpleados(String oficio,int deptno)
        {
            return context.Empleados.Where(x => x.Oficio == oficio && x.DeptNo == deptno).ToList();
        }
    }
}
