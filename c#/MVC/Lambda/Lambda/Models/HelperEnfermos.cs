using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambda.Models
{
    public class HelperEnfermos
    {
        HOSPITALEntities e;
       public HelperEnfermos()
        {
            e = new HOSPITALEntities();
        }
        public List<ENFERMO> GetEnfermos()
        {
            List<ENFERMO> enfermos = e.MOSTRARENFERMO().ToList();
            return enfermos;
        }
        public Boolean DeleteEnfermo(String inscripcion)
        {
            int afectados = e.ELIMINARENFERMO(int.Parse(inscripcion));
            if(afectados > 0)
            {
                return true;
            }
            return false;
        }
    }
}