using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.TraceListener;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices;
using Microsoft.Extensions.Logging.Console;
using ProyectoCore.Data;
using ProyectoCore.Repositories;

namespace ProyectoCore
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //SERVICES COOKIE
            services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Comportamiento de la sesión
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


            //INVERSION DE CONTROL IoC
            services.AddTransient<IRepositoryHospital,RepositoryHospital>();
            services.AddDbContext<IHospitalContext, Hospital>(options => options.UseMySql(configuration.GetConnectionString("CadenaHospitalMySQL")));
           
            //DEBEMOS INDICAR QUE ARRANQUE EL SERVICIO DEL 
            //MIDELWARE
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //LOGGER AZURE
            loggerFactory.AddAzureWebAppDiagnostics(
            new AzureAppServicesDiagnosticsSettings
            {
            OutputTemplate =
                "{Timestamp:dd-MM-yyyy HH:mm:ss zzz} [{Level}] {RequestId}-{SourceContext}: {Message}{NewLine}{Exception}"
            }
            );

            //TRACE PARA LAS MÉTRICAS
            Trace.Listeners.Add(new ApplicationInsightsTraceListener());

            //1.COTROL DE ERRORES
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           

            //4.UTILIZAMOS ARCHIVOS DE WWWROOT
            app.UseStaticFiles();

            //5.Cookies
            app.UseCookiePolicy();

            //7.SESSION
            app.UseSession();

            //8.DEBEMOS DAR LA RUTA DE INICIO
            //MAPEAMOS LAS AREAS
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Zelda}/{action=Index}/{id?}"
                );
            });

            //MAPEOAMOS GENERAL
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
