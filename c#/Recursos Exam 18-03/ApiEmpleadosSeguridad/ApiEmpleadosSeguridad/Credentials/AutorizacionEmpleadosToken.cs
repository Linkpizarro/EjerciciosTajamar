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
    public class AutorizacionEmpleadosToken: 
        OAuthAuthorizationServerProvider
    {
        RepositoryEmpleados repo;

        public AutorizacionEmpleadosToken()
        {
            this.repo = new RepositoryEmpleados();
        }

        public override Task ValidateClientAuthentication
            (OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }

        public override Task GrantResourceOwnerCredentials
            (OAuthGrantResourceOwnerCredentialsContext context)
        {
            //DEBEMOS VALIDAR EL USUARIO Y PASSWORD
            //DICHOS VALORES VIENEN DENTRO DEL CONTEXT
            String apellido = context.UserName;
            int empno = int.Parse(context.Password);
            Empleado empleado =
                this.repo.ExisteEmpleado(apellido, empno);
            if (empleado == null)
            {
                //SI NO EXISTE EL EMPLEADO, INCLUIMOS UN ERROR
                //DENTROL CONTEXT PARA QUE NO LO VALIDE
                context.SetError("Usuario/Password incorrectos"
                    , "Has introducido mal tus credenciales");
            }
            else
            {
                //EL EMPLEADO EXISTE Y CREAMOS UNA IDENTIDAD
                ClaimsIdentity identidad =
new ClaimsIdentity(context.Options.AuthenticationType);
                //AÑADIMOS DATOS A LA IDENTIDAD POR SI
                //DESEAMOS UTILIZARLOS EN ALGUNO MOMENTO
identidad.AddClaim(new Claim(ClaimTypes.Name, empleado.Apellido));
identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier,
                    empleado.IdEmpleado.ToString()));
identidad.AddClaim(new Claim(ClaimTypes.Role, empleado.Oficio));
                //INCLUIMOS LA IDENTIDAD DENTRO DE LA VALIDACION
                context.Validated(identidad);
            }
            return base.GrantResourceOwnerCredentials(context);
        }
    }
}