using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaLINQ.Models
{
    public class HelperDept
    {
        ContextHospitalDataContext c;

        public HelperDept()
        {
            this.c = new ContextHospitalDataContext();
        }
        public List<DEPT> GetAllDept()
        {
            var linq = from datos in c.DEPTs
                       orderby datos.DEPT_NO ascending
                       select datos;

            return linq.ToList();
        }

        public void SetDept(String dept_no,String dnombre,String loc)
        {
            DEPT dept = new DEPT();
            dept.DEPT_NO = int.Parse(dept_no);
            dept.DNOMBRE = dnombre;
            dept.LOC = loc;
            c.DEPTs.InsertOnSubmit(dept);
            c.SubmitChanges();
        }

        public void DelDept(String dept_no)
        {

            DEPT dept = (from datos in c.DEPTs
                       where datos.DEPT_NO == int.Parse(dept_no)
                       select datos).First();

            c.DEPTs.DeleteOnSubmit(dept);
            c.SubmitChanges();

        }
    }
}