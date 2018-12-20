using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaLINQ.Models
{
    public class HelperDeptEmp
    {
        ContextHospitalDataContext c;
        public HelperDeptEmp()
        {
            c = new ContextHospitalDataContext();
        }

        public List<String> GetDept()
        {
            var linq = from data in c.DEPTs
                       select data.DNOMBRE;

            return linq.ToList();
        }

        public List<EMP> GetEmp(String dept)
        {
            var dept_no = (from data in c.DEPTs
                          where data.DNOMBRE == dept
                          select data.DEPT_NO).First();

            var linq = from data in c.EMPs
                       where data.DEPT_NO == dept_no
                       select data;

            return linq.ToList();
        }
        public void DelEmp(String emp_no)
        {
            EMP emp = (from data in c.EMPs
                      where data.EMP_NO == int.Parse(emp_no)
                      select data).First();

            c.EMPs.DeleteOnSubmit(emp);
            c.SubmitChanges();
        }
    }
}