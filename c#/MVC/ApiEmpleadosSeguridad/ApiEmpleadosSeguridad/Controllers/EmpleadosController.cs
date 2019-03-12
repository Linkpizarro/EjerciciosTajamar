using ApiEmpleadosSeguridad.Models;
using ApiEmpleadosSeguridad.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiEmpleadosSeguridad.Controllers
{
    public class EmpleadosController : ApiController
    {
        EmpleadosRepository repo;
        public EmpleadosController()
        {
            this.repo = new EmpleadosRepository();
        }
        [Authorize]
        public List<Empleado> GetEmpleados()
        {
            return repo.GetEmpleados();
        }

      
        public Empleado Get(int id)
        {
            return repo.GetEmpleado(id);
        }
    }
}
