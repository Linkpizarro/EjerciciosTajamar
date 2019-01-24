using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadPlantilla.Models
{
    public class RepositoryValidation
    {
        PlantillaContext context;
        public RepositoryValidation()
        {
            context = new PlantillaContext();
        }

        public Plantilla ValidateUser(String surname,int password)
        {
            Plantilla emp = (from data in context.Empleados
                             where data.Apellido == surname
                             && data.Emp_no == password
                             select data).FirstOrDefault();
            return emp;
        }
    }
}