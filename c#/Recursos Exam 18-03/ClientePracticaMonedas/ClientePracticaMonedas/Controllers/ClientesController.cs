using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClientePracticaMonedas.Models;
using ClientePracticaMonedas.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientePracticaMonedas.Controllers
{
    public class ClientesController : Controller
    {
        ValidationRepository validation;
        ClientesRepository repo;
        public ClientesController(ValidationRepository validation, ClientesRepository repo)
        {
            this.validation = validation;
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            String token = HttpContext.Session.GetString("token");
            int id = int.Parse(HttpContext.User.Identity.Name);
            Cliente cliente = await this.repo.GetCliente(id,token);
            return View(cliente);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(String usuario, String password)
        {
            String token = await this.validation.GetToken(usuario, password);
            if (token != null)
            {

                HttpContext.Session.SetString("token", token);
                Cliente cliente = await this.repo.GetPerfil(token);
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.Name, cliente.Cliente_Id.ToString()));
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.Now.AddMinutes(30)
                    }
                );
                return RedirectToAction("Index", "Clientes");
            }
            else
            {
                ViewData["Error"] = "Usuario/Password incorrectos";
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await this.repo.PostCliente(cliente);
                return RedirectToAction("Login", "Clientes");
            }
            return View(cliente);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}