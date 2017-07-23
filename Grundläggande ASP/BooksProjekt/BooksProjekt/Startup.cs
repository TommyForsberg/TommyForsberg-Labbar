using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BooksProjekt.Models.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BooksProjekt.Models;

namespace BooksProjekt
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InforTenta;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<BookContext>(
                options => options.UseSqlServer(connstring));

            Mapper.Initialize((config) =>
            {
                
                config.CreateMap<Book, CreateBookVM>();
                config.CreateMap<Book, ListBooksVM>()
                .ForMember(x => x.IsAClassic, o => o.MapFrom(s => s.Pages > 200));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {

            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

        }
    }
}
