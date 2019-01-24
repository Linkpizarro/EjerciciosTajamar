using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguridadPlantilla.Models
{
    public class RepositoryPlantilla
    {
        PlantillaContext context;
        public RepositoryPlantilla()
        {
            context = new PlantillaContext();
        }

        public List<Plantilla> GetPlantilla()
        {
            List<Plantilla> empleados = (from data in context.Empleados
                                         select data).ToList();
            return empleados;
        }
    }
}