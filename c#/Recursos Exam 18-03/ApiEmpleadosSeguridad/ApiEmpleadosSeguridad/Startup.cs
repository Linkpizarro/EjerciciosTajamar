using System;
using System.Threading.Tasks;
using System.Web.Http;
using ApiEmpleadosSeguridad.Credentials;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(ApiEmpleadosSeguridad.Startup))]

namespace ApiEmpleadosSeguridad
{
    public class Startup
    {
        //DEBEMOS CREAR UN METODO QUE CONFIGURE
        //EL ENDPOINT DE ACCESO AL LOGIN
        //EL TIEMPO DE ACCESO CON EL TOKEN
        //Y LA CLASE PARA VALIDAR EL USUARIO
        public void ConfigurarOAuth(IAppBuilder app)
        {
            //LO PRIMERO ES CREARNOS LA CLASE CON LAS
            //OPCIONES DE LA CONFIGURACION DE SEGURIDAD
            OAuthAuthorizationServerOptions authoptions =
                new OAuthAuthorizationServerOptions()
                {
                    //PERMITIR ACCESO DESDE HTTP
                    AllowInsecureHttp = true
                    //RUTA DE ACCESO AL TOKEN
                    , TokenEndpointPath = new PathString("/login")
                    //TIEMPO DE ACCESO CON EL TOKEN
                    , AccessTokenExpireTimeSpan =
                    TimeSpan.FromMinutes(10)
                    //LA CLASE QUE SE ENCARGAR DE VALIDAR AL USUARIO
                    , Provider = new AutorizacionEmpleadosToken()
                };
            //INDICAR A NUESTRA APP LAS OPCIONES DE AUTORIZACION
            app.UseOAuthAuthorizationServer(authoptions);
            //CREARNOS LAS OPCIONES DE AUTORIZACION BEARER
            //QUE NOS GENERARA EL TOKEN
            OAuthBearerAuthenticationOptions beareroptions =
                new OAuthBearerAuthenticationOptions()
                {
                    //INDICAMOS QUE UTILIZAMOS LA AUTORIZACION
                    //DE TIPO OWIN ESTA ACTIVADA
                    AuthenticationMode =
                    Microsoft.Owin.Security.AuthenticationMode.Active
                };
            //CONFIGURAMOS LA APLICACION INDICANDO LAS OPCIONES
            //DE SEGURIDAD BEARER
            app.UseOAuthBearerAuthentication(beareroptions);
        }

        public void Configuration(IAppBuilder app)
        {
            //ESTE METODO ES EL ACCESO DE ARRANQUE DE
            //NUESTRA APP WEB API
            //CREAMOS EL OBJETO PARA CONFIGURACION DE NUESTRO API
            HttpConfiguration config = new HttpConfiguration();
            //REGISTRAR LAS RUTAS DE ACCESO A NUESTRO API
            WebApiConfig.Register(config);
            //SI DESEAMOS INCLUIR SEGURIDAD, LLAMAMOS
            //AL METODO DE CONFIGURACION OAUTH
            ConfigurarOAuth(app);
            //INDICAMOS A LA APLICACION LA CONFIGURACION DEL API
            app.UseWebApi(config);
        }
    }
}
