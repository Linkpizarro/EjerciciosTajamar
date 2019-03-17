using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteApiSeguridadCore.Filters;
using ClienteApiSeguridadCore.Models;
using ClienteApiSeguridadCore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiSeguridadCore.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryApiEmpleados repo;

        public EmpleadosController(IRepositoryApiEmpleados repo)
        {
            this.repo = repo;
        }

        [EmpleadosAuthorize]
        public async Task<IActionResult> Index()
        {
            String token = HttpContext.Session.GetString("TOKEN");
            Empleado empleado = await
                this.repo.PerfilEmpleado(token);
            return View(empleado);
        }

    }
}