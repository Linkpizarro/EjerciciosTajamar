using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEmpleadosCore.Models;
using ApiEmpleadosCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpleadosCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        EmpleadosRepository repo;
       public EmpleadosController(EmpleadosRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Empleado> Get()
        {
            return this.repo.GetEmpleados();
        }
        [HttpGet("{id}")]
        public Empleado Get(int id)
        {
            return this.repo.GetEmpleado(id);
        }
        [HttpGet("{oficio}/{deptno}")]
        public List<Empleado> GetEmpleados(String oficio,int deptno)
        {
            return repo.GetEmpleados(oficio, deptno);
        }
        [HttpGet]
        [Route("[action]/{salario}")]
        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            return repo.GetEmpleadosSalario(salario);
        }
    }
}