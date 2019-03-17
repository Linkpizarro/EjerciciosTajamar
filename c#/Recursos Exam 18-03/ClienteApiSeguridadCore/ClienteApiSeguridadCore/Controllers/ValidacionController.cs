using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClienteApiSeguridadCore.Models;
using ClienteApiSeguridadCore.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApiSeguridadCore.Controllers
{
    public class ValidacionController : Controller
    {
        IRepositoryApiEmpleados repo;

        public ValidacionController(IRepositoryApiEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>
                 Login(String usuario, String password)
        {
            //BUSCAMOS EL TOKEN PARA COMPROBAR LAS CREDENCIALES
            //DEL EMPLEADO
            String token = await this.repo.GetToken(usuario, password);
            //SI EL TOKEN ES NULL, NO TIENE CREDENCIALES
            if (token != null)
            {
                //SI TENEMOS TOKEN, TENEMOS EMPLEADO
                //POR LO QUE PODEMOS RECUPERARLO DEL METODO PERFILEMPLEADO
                Empleado empleado = await
                    this.repo.PerfilEmpleado(token);
                //CREAMOS AL USUARIO PARA EL ENTORNO MVC DE CORE
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                //ALMACENAMOS EL ID DE EMPLEADO
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier
                    , empleado.IdEmpleado.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Name, empleado.Apellido));
                //GUARDAMOS TAMBIEN EL ROLE DEL EMPLEADO
                identity.AddClaim(new Claim(ClaimTypes.Role, empleado.Oficio));
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme, principal
                    , new AuthenticationProperties
                    {
                        IsPersistent = true
                    ,//DEBERIAMOS DAR EL MISMO TIEMPO DE SESSION QUE TOKEN
                        ExpiresUtc = DateTime.Now.AddMinutes(10)
                    });
                //UNA VEZ QUE TENEMOS A NUESTRO EMPLEADO ALMACENADO
                //DEBEMOS ALMACENAR EL TOKEN EN SESSION PARA PODER REUTILIZARLO
                //EN OTROS METODOS DE LA APP
                HttpContext.Session.SetString("TOKEN", token);
                //REDIRECCIONAMOS A UNA PAGINA DE INICIO PROTEGIDA
                return RedirectToAction("Index", "Empleados");
            }
            else
            {
                ViewBag.Mensaje = "Usuario/Password incorrectos";
                return View();
            }
        }
    }
}
