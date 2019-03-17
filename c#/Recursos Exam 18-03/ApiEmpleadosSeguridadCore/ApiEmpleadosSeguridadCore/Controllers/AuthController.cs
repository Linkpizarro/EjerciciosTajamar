using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ApiEmpleadosSeguridadCore.Models;
using ApiEmpleadosSeguridadCore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace ApiEmpleadosSeguridadCore.Controllers
{
    //http://localhost/auth/login
    //POST
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        RepositoryEmpleados repo;
        IConfiguration configuration;

        public AuthController(RepositoryEmpleados repo
            , IConfiguration configuration)
        {
            this.configuration = configuration;
            this.repo = repo;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            Empleado empleado =
                this.repo.ExisteEmpleado(model.UserName
                , int.Parse(model.Password));
            if (empleado != null)
            {
                //ESTA ES LA INFORMACION QUE VAMOS A INCLUIR EN 
                //NUESTRO TOKEN PARA PODER RECUPERARLA POSTERIORMENTE
                Claim[] claims = new[]
                {
                    new Claim("UserData", JsonConvert.SerializeObject(empleado))
                };

                //GENERAMOS EL TOKEN CON LA INFORMACION
                JwtSecurityToken token = new JwtSecurityToken
                (
                    issuer: configuration["ApiAuth:Issuer"],
                    audience: configuration["ApiAuth:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["ApiAuth:SecretKey"])),
                    SecurityAlgorithms.HmacSha256)
                );

                // Devolvemos el token en la respuesta
                return Ok(
                    new
                    {
                        response = new JwtSecurityTokenHandler()
                        .WriteToken(token)
                    }
                );
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}