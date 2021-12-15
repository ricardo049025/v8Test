using Domain.Domain.Interfaces;
using Domain.Domain.Interfaces.Services;
using Domain.Entities;
using Infraestructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Service.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiV8
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<V8Context>(options => options.UseSqlServer(Configuration.GetConnectionString("sqlConnection")));

            services.AddScoped<ISalaryRepository, SalaryRepository>();
            services.AddScoped<IDivisionRepository, DivisionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IOfficeRepository, OfficeRepository>();

            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IDivisionService, DivisionService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IOfficeService, OfficeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true)
               .AllowCredentials());
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>{endpoints.MapControllers();});
        }
    }
}
