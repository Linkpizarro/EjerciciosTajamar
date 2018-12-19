using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaLINQ.Models
{
    public class HelperHome
    {
        ContextHospitalDataContext c;

        public HelperHome()
        {
            this.c = new ContextHospitalDataContext();
        }
        public List<DEPT> GetAllDept()
        {
            var linq = from datos in c.DEPTs
                       select datos;

            return linq.ToList();
        }

        public List<DEPT> GetDeptByLoc(String loc)
        {
            var linq = from data in c.DEPTs
                       where data.LOC == loc
                       select data;

            if (linq.Count() == 0)
            {
                return null;
            }
            else
            {
                return linq.ToList();
            }
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
    }
}