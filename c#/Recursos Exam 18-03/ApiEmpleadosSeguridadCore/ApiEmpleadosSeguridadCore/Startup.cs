using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEmpleadosSeguridadCore.Data;
using ApiEmpleadosSeguridadCore.Repositories;
using ApiEmpleadosSeguridadCore.Token;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiEmpleadosSeguridadCore
{
    public class Startup
    {
        IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            HelperToken helpertoken = new HelperToken(this.Configuration);
            String cadenaconexion =
                Configuration.GetConnectionString("cadenahospitalazure");
            services.AddDbContext<EmpleadosContext>(options =>
            options.UseSqlServer(cadenaconexion));
            services.AddTransient<RepositoryEmpleados>();
            services.AddAuthentication(helpertoken.GetAuthOptions())
                .AddJwtBearer(helpertoken.GetJwtOptions());
            services.AddMvc();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
