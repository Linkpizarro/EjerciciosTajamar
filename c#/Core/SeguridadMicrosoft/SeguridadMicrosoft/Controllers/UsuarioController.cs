using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SeguridadMicrosoft.Controllers
{
    public class UsuarioController : Controller
    {
        [Authorize]
        public IActionResult PerfilUsuario()
        {
            return View();
        }
    }
}