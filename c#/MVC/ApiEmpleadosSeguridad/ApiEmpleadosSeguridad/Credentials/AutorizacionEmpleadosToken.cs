using ApiEmpleadosSeguridad.Models;
using ApiEmpleadosSeguridad.Repositories;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ApiEmpleadosSeguridad.Credentials
{
    public class AutorizacionEmpleadosToken : OAuthAuthorizationServerProvider
    {
        EmpleadosRepository repo;
        public AutorizacionEmpleadosToken()
        {
            this.repo = new EmpleadosRepository();
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            String apellido = context.UserName;
            int id = int.Parse(context.Password);
            Empleado empleado = repo.ExistEmpleado(apellido, id);
            if(empleado == null)
            {
                context.SetError("Usuario/Password incorectos", "Las credenciales son incorrectas.");
            }
            else
            {
                ClaimsIdentity identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name,empleado.Surname));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, empleado.Id.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Role, empleado.Ofice));
                context.Validated(identity);
            }
            return base.GrantResourceOwnerCredentials(context);
        }
    }
}