using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadEmpleados.Models
{
    public class RepositoryEmpleados
    {
        EmpleadoContext context;

        public RepositoryEmpleados()
        {
            context = new EmpleadoContext();
        }

        public Empleado ExisteEmpleado(String apellido,int emp_no)
        {
            Empleado consulta = (from datos in context.Empleados
                            where datos.Apellido == apellido
                            && datos.IdEmpleado == emp_no
                            select datos).FirstOrDefault();

            return consulta;
        }

        public List<Empleado> Subordinados(int director)
        {
            List<Empleado> consulta = (from datos in context.Empleados
                                      where datos.Director == director
                                      select datos).ToList();

            if (consulta.Count() == 0) {

                return null;
            }

            return consulta;
        }

        public Empleado BuscarEmpleado(int emp_no)
        {
            Empleado consulta = (from datos in context.Empleados
                                 where datos.IdEmpleado == emp_no
                                 select datos).FirstOrDefault();
            return consulta;
        }

        public void ModificarEmpleado(int emp_no,String apellido,String oficio,int salario)
        {
            Empleado emp = this.BuscarEmpleado(emp_no);
            emp.Apellido = apellido;
            emp.Oficio = oficio;
            emp.Salario = salario;
            context.SaveChanges();
        }
    }
}