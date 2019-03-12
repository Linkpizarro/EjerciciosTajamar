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
        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions authoptions =
                new OAuthAuthorizationServerOptions() {
                    AllowInsecureHttp = true,
                    TokenEndpointPath = new PathString("/login"),
                    AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(10),
                    Provider = new AutorizacionEmpleadosToken()
                };
            app.UseOAuthAuthorizationServer(authoptions);
            OAuthBearerAuthenticationOptions bareroptions =
                new OAuthBearerAuthenticationOptions()
                {
                    AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active
                };
            app.UseOAuthBearerAuthentication(bareroptions);
        }
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            ConfigureOAuth(app);
            app.UseWebApi(config);
        }
    }
}
