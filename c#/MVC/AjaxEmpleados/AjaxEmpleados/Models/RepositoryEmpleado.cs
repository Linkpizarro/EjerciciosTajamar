using AjaxEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AjaxEmpleados.Controllers
{
    
    public class RepositoryEmpleado
    {
        EmpleadosContext context = new EmpleadosContext();

        public List<EMP> GetEmpleados()
        {
            var empleados = from data in context.EMP
                            select data;
            return empleados.ToList();
        }
        public EMP GetEmpleado(int empno)
        {
            var empleado = from data in context.EMP
                           where data.EMP_NO == empno
                           select data;

            return empleado.FirstOrDefault();
        }                   
    }
}