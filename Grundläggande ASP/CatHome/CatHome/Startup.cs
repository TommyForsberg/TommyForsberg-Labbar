using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CatHome.Models.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using CatHome.Models;

namespace CatHome
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            var connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CatHome;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<CatHomeContext>(
                options => options.UseSqlServer(connstring));

            services.AddSession();
            services.AddMvc();

            Mapper.Initialize((config) =>
            {
                config.CreateMap<CreateCatVM, Cat>();
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseSession();
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
        }
    }
}
