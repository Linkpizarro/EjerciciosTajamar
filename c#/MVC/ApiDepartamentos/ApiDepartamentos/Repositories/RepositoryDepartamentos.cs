using ApiDepartamentos.Data;
using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;

        public RepositoryDepartamentos()
        {
            this.context = new DepartamentosContext();
        }

        public List<Departamento> GetDepartamentos()
        {
            return this.context.Departamentos.ToList();
        }

        public Departamento BuscarDepartamento(int deptno)
        {
            return this.context.Departamentos
                .SingleOrDefault(x => x.Numero == deptno);
        }

        public void InsertarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = new Departamento();
            dept.Numero = num;
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }

        public void ModificarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = this.BuscarDepartamento(num);
            dept.Nombre = nom;
            dept.Localidad = loc;
            this.context.SaveChanges();
        }

        public void EliminarDepartamento(int num)
        {
            Departamento dept = this.BuscarDepartamento(num);
            this.context.Departamentos.Remove(dept);
            this.context.SaveChanges();
        }


        public List<Empleado> GetEmpleados(List<int?> departamentos)
        {
            var consulta = from data in context.Empleados
                           where departamentos.Contains(data.Dept)
                           select data;

            return consulta.ToList();
        }
    }
}