using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lambda.Models
{
    public class HelperEmp
    {
        HOSPITALEntities entidad;

        public HelperEmp()
        {
            entidad = new HOSPITALEntities();
        }
        public List<MOSTRAREMPLEADO_Result> GetEmp()
        {
            var empleados = entidad.MOSTRAREMPLEADO();
            return empleados.ToList();
        }
        public List<MOSTRAREMPLEADOPAGINADO_Result> GetEmpPag(int max,int min)
        {
           var empleados = entidad.MOSTRAREMPLEADOPAGINADO(max,min);
           return empleados.ToList();
        }

        public List<String> GetOficios()
        {
            var consulta = (from datos in entidad.EMP
                           select datos.OFICIO).Distinct();

            return consulta.ToList();
        }
        public List<EMP> GetEmpOficios(String oficio)
        {
            var consulta = from datos in entidad.EMP
                           where datos.OFICIO == oficio
                           select datos;

            return consulta.ToList();
        }
        public ResumenEmp GetResumenOficio(String oficio)
        {
            List<EMP> emp = this.GetEmpOficios(oficio);
            int personas = emp.Count();
            int? maximo = emp.Max(x => x.SALARIO);
            int? suma = emp.Sum(x => x.SALARIO);
            double? media = emp.Average(x => x.SALARIO);

            ResumenEmp res = new ResumenEmp();
            res.Personas = personas;
            res.MaxSalario = maximo.GetValueOrDefault();
            res.SumSalario = suma.GetValueOrDefault();
            res.MedSalario = media.GetValueOrDefault();

            return res;
        }

        public List<String> GetDepartamentos()
        {
            var consulta = (from datos in entidad.DEPT
                            select datos.DNOMBRE).Distinct();

            return consulta.ToList();
        }
        public List<EMP> GetEmpDepartamento(String dept)
        {
            int dept_no = (from datos in entidad.DEPT
                          where datos.DNOMBRE == dept
                          select datos.DEPT_NO).FirstOrDefault();

            List<EMP> consulta = (from datos in entidad.EMP
                           where datos.DEPT_NO == dept_no
                           select datos).ToList();

            return consulta;
        }
        public ResumenEmp GetResumenDepartamento(String dept)
        {
            List<EMP> emp = this.GetEmpDepartamento(dept);
            int personas = emp.Count();
            int? maximo = emp.Max(x => x.SALARIO);
            int? suma = emp.Sum(x => x.SALARIO);
            double? media = emp.Average(x => x.SALARIO);

            ResumenEmp res = new ResumenEmp();
            res.Personas = personas;
            res.MaxSalario = maximo.GetValueOrDefault();
            res.SumSalario = suma.GetValueOrDefault();
            res.MedSalario = media.GetValueOrDefault();

            return res;
        }


    }

}