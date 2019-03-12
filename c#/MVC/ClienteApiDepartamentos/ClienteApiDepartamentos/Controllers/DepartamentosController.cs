using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiDepartamentos.Models;
using ClienteApiDepartamentos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiDepartamentos.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryApiDepartamentos repo;

        public DepartamentosController(RepositoryApiDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> DepartamentosServidor()
        {
            List<Departamento> departamentos = await
                this.repo.GetDepartamentosAsync();
            return View(departamentos);
        }

        public async Task<IActionResult> DetallesDepartamento(int deptno)
        {
            Departamento dept = 
                await this.repo.BuscarDepartamentoAsync(deptno);
            return View(dept);
        }

        public IActionResult InsertarDepartamento()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>
            InsertarDepartamento(Departamento dept)
        {
            await this.repo.InsertarDepartamentoAsync(dept.Numero
                , dept.Nombre, dept.Localidad);
            return RedirectToAction("DepartamentosServidor");
        }

        public async Task<IActionResult> ModificarDepartamento(int deptno)
        {
            Departamento dept =
                await this.repo.BuscarDepartamentoAsync(deptno);
            return View(dept);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarDepartamento
            (Departamento dept)
        {
            await this.repo.ModificarDepartamentoAsync(dept.Numero
                , dept.Nombre, dept.Localidad);
            return RedirectToAction("DepartamentosServidor");
        }

        public async Task<IActionResult> EliminarDepartamento(int deptno)
        {
            await this.repo.EliminarDepartamentoAsync(deptno);
            return RedirectToAction("DepartamentosServidor");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DepartamentosCliente()
        {
            return View();
        }

        public async Task<IActionResult> EmpleadosDepartamento()
        {
            List<Departamento> departamentos = await repo.GetDepartamentosAsync();
            ViewData["Departamentos"] = departamentos;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmpleadosDepartamento(List<int> dept_no)
        {
            List<Departamento> departamentos = await repo.GetDepartamentosAsync();
            ViewData["Departamentos"] = departamentos;
            List<Empleado> empleados = await repo.GetEmpleadosDepartamentoAsync(dept_no);
            return View(empleados);
        }
    }
}