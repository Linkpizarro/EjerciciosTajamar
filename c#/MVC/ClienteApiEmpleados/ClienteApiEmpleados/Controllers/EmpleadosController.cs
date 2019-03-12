using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiEmpleados.Models;
using ClienteApiEmpleados.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiEmpleados.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryApiEmpleados repo;

        public EmpleadosController
            (IRepositoryApiEmpleados repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> EmpleadosServidor()
        {
            List<Empleado> empleados =
                await this.repo.GetEmpleados();
            return View(empleados);
        }
        [HttpPost]
        public async Task<IActionResult> EmpleadosServidor(int salario)
        {
            List<Empleado> empleados = await repo.GetEmpleadosSalario(salario);
            return View(empleados);
        }

        public async Task<IActionResult> DetalleEmpleado(int idempleado)
        {
            Empleado empleado = await repo.BuscarEmpleado(idempleado);
            return View(empleado);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmpleadosCliente()
        {
            return View();
        }
    }
}