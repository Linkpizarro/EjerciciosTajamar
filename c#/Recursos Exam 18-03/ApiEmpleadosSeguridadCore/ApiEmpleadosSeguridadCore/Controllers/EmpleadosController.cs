using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApiEmpleadosSeguridadCore.Models;
using ApiEmpleadosSeguridadCore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiEmpleadosSeguridadCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [Authorize]
        [HttpGet]
        public List<Empleado> Get()
        {
            return repo.GetEmpleados();
        }

        [HttpGet("{id}")]
        public Empleado Get(int id)
        {
            return repo.BuscarEmpleado(id);
        }

        [Authorize]
        [HttpGet]
        [Route("[action]")]
        public Empleado PerfilEmpleado()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();
            String jsonempleado =
                claims.SingleOrDefault(x => x.Type == "UserData").Value;
            Empleado empleado = JsonConvert.DeserializeObject<Empleado>(jsonempleado);
            return empleado;
        }

        [Authorize]
        [HttpGet]
        [Route("[action]")]
        public List<Empleado> GetSubordinados()
        {
            List<Claim> claims = HttpContext.User.Claims.ToList();
            String jsonempleado =
                claims.SingleOrDefault(x => x.Type == "UserData").Value;
            Empleado empleado = JsonConvert.DeserializeObject<Empleado>(jsonempleado);
            List<Empleado> subordinados =
                this.repo.GetEmpleadosSubordinados(empleado.IdEmpleado);
            return subordinados;
        }

    }
}