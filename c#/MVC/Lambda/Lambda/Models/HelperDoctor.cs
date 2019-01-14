using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambda.Models
{

    public class HelperDoctor
    {
        HOSPITALEntities entidad;
        public HelperDoctor()
        {
            entidad = new HOSPITALEntities();
        }

        public List<HOSPITAL> GetHospitales()
        {
            List<HOSPITAL> hospitales = (from data in entidad.HOSPITAL
                                         select data).ToList();
            return hospitales;
        }

        public List<List<DOCTOR>> GetDoctores(List<int> hospitales)
        {
            List<List<DOCTOR>> result = new List<List<DOCTOR>>();
            foreach (int item in hospitales)
            {
                List<DOCTOR> doctores = (from data in entidad.DOCTOR
                                         where data.HOSPITAL_COD == item.ToString()
                                         select data).ToList();
                result.Add(doctores);
            }
            

            return result;
            

        }
    }
}