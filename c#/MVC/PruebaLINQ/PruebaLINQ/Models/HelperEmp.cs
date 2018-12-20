using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaLINQ.Models
{
    public class HelperEmp
    {
        ContextHospitalDataContext c;
        public HelperEmp()
        {
            c = new ContextHospitalDataContext();
        }

        public List<String> GetOficios()
        {
            var linq = (from data in c.EMPs
                       select data.OFICIO).Distinct();

            return linq.ToList();
        }
        public List<EMP> GetEmp()
        {
            var linq = from data in c.EMPs
                       select data;

            return linq.ToList();
        }
        public void UpdateSalario(String oficio,String increment)
        {
           var modificados = from data in c.EMPs
                      where data.OFICIO == oficio
                      select data;

            foreach (EMP item in modificados)
            {
                item.SALARIO += int.Parse(increment); 
            }

            c.SubmitChanges();
        }
    }
}