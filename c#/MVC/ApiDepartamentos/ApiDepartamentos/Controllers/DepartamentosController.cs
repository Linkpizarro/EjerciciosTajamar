using ApiDepartamentos.Models;
using ApiDepartamentos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiDepartamentos.Controllers
{
    public class DepartamentosController : ApiController
    {
        RepositoryDepartamentos repo;

        public DepartamentosController()
        {
            this.repo = new RepositoryDepartamentos();
        }

        //api/Departamentos
        public List<Departamento> GetDepartamentos()
        {
            return this.repo.GetDepartamentos();
        }

        //api/Departamentos/{id}
        public Departamento Get(int id)
        {
            return this.repo.BuscarDepartamento(id);
        }

        //InsertDept [HttpPost] [Route("api/InsertDept")
        //api/Departamentos
        public void Post(Departamento dept)
        {
            this.repo.InsertarDepartamento(dept.Numero, dept.Nombre
                , dept.Localidad);
        }

        //PUT: Modificar dept
        //api/Departamentos/{id}
        public void Put(int id, Departamento dept)
        {
            this.repo.ModificarDepartamento(dept.Numero, dept.Nombre
                , dept.Localidad);
        }

        //api/Departamentos/{id}
        public void Delete(int id)
        {
            this.repo.EliminarDepartamento(id);
        }

        //api/EmpleadosDept?dept_no=10&dept_no=20
        [HttpGet]
        [Route("api/EmpleadosDept")]
        public List<Empleado> EmpleadosDept([FromUri]List<int?> dept_no)
        {
            return repo.GetEmpleados(dept_no);
        }
    }
}
