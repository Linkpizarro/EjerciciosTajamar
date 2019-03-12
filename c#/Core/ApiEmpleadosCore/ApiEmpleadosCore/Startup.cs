using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEmpleadosCore.Data;
using ApiEmpleadosCore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiEmpleadosCore
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddDbContext<EmpleadosContext>(options => options.UseSqlServer(this.configuration.GetConnectionString("CadenaAzure")));
            services.AddTransient<EmpleadosRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
