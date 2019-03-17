using ApiEmpleadosSeguridad.Models;
using ApiEmpleadosSeguridad.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace ApiEmpleadosSeguridad.Controllers
{
    public class EmpleadosController : ApiController
    {
        RepositoryEmpleados repo;

        public EmpleadosController()
        {
            this.repo = new RepositoryEmpleados();
        }

   
        public List<Empleado> GetEmpleados()
        {
            return this.repo.GetEmpleados();
        }

        [Authorize]
        [HttpGet]
        [Route("api/PerfilEmpleado")]
        public Empleado PerfilEmpleado()
        {
            ClaimsIdentity identidad =
                User.Identity as ClaimsIdentity;
            int empno = int.Parse(
                identidad.FindFirst(ClaimTypes.NameIdentifier).Value
                );
            Empleado empleado = this.repo.BuscarEmpleado(empno);
            return empleado;
        }

        [Authorize]
        [HttpGet]
        [Route("api/Subordinados")]
        public List<Empleado> Subordinados()
        {
            ClaimsIdentity identidad =
                User.Identity as ClaimsIdentity;
            int empno = int.Parse(
                identidad.FindFirst(ClaimTypes.NameIdentifier).Value
                );
            List<Empleado> empleados = 
                this.repo.GetEmpleadosSubordinados(empno);
            return empleados;
        }

        public Empleado Get(int id)
        {
            return this.repo.BuscarEmpleado(id);
        }
    }
}
