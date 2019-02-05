using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            //INVERSION DE CONTROL IoC
            services.AddTransient<RepositoryHospital>();
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(configuration.GetConnectionString("CadenaHospital")));

            //DEBEMOS INDICAR QUE ARRANQUE EL SERVICIO DEL 
            //MIDELWARE
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //1.COTROL DE ERRORES
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            //4.UTILIZAMOS ARCHIVOS DE WWWROOT
            app.UseStaticFiles();

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
