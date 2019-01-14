using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConceptosMVC.Models
{
    public class HelperDepartamento
    {
        HospitalEntity e;
        public HelperDepartamento()
        {
            e = new HospitalEntity();
        }

        public List<DEPT> GetDepts()
        {
            List<DEPT> depts = (from data in e.DEPT
                                select data).ToList();
            return depts;
        }

        public void Create(DEPT dept)
        {
            int id = (from data in e.DEPT
                      orderby data.DEPT_NO descending
                      select data.DEPT_NO).FirstOrDefault();

            dept.DEPT_NO = id + 10;
            e.DEPT.Add(dept);
            e.SaveChanges();
        }

        public DEPT GetDept(String dept_no)
        {
            DEPT dept = (from data in e.DEPT
                        where data.DEPT_NO == int.Parse(dept_no)
                        select data).FirstOrDefault();

            return dept;
        }

        public void Update(DEPT dept)
        {
            e.DEPT.Add(dept);
            e.SaveChanges();
        }
    }
}