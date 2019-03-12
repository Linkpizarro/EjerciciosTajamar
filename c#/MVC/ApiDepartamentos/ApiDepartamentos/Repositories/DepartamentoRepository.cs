using ApiDepartamentos.Data;
using ApiDepartamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Repositories
{
    public class DepartamentoRepository
    {
        DepartamentoContext context;
        public DepartamentoRepository()
        {
            this.context = new DepartamentoContext();
        }

        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }
        public Departamento GetDepartamento(int dept)
        {
            return context.Departamentos.SingleOrDefault(d => d.Numero == dept);
        }
        public void InsertDepartamento(int numero,string nombre,string localidad)
        {
            Departamento dept = new Departamento()
            {
                Numero = numero,
                Nombre = nombre,
                Localidad = localidad
            };
            context.Departamentos.Add(dept);
            context.SaveChanges();

        }
        public void UpdateDepartamento(int numero,string nombre,string localidad)
        {
            Departamento dept = GetDepartamento(numero);
            dept.Nombre = nombre;
            dept.Localidad = localidad;
            context.SaveChanges();
        }
        public void DeleteDepartamento(int numero)
        {
            Departamento dept = GetDepartamento(numero);
            context.Departamentos.Remove(dept);
            context.SaveChanges();
        }
    }
}