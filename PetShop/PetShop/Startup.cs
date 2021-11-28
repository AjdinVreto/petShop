using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Model.Requests;
using PetShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddDbContext<PetShopContext>(
                options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

            services.AddSwaggerGen();

            services.AddScoped<IProizvodService, ProizvodService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<IUposlenikService, UposlenikService>();
            services.AddScoped<IKategorijaService, KategorijaService>();
            services.AddScoped<IProizvodjacService, ProizvodjacService>();
            services.AddScoped<IKontaktService, KontaktService>();
            services.AddScoped<IPoslovnicaService, PoslovnicaService>();
            services.AddScoped<INovostService, NovostService>();
            services.AddScoped<IReadService<Model.Rola, object>, BaseReadService<Model.Rola, Database.Rola, object>>();
            services.AddScoped<IReadService<Model.Spol, object>, BaseReadService<Model.Spol, Database.Spol, object>>();
            services.AddScoped<IReadService<Model.Drzava, object>, BaseReadService<Model.Drzava, Database.Drzava, object>>();
            services.AddScoped<IReadService<Model.Proizvodjac, object>, BaseReadService<Model.Proizvodjac, Database.Proizvodjac, object>>();
            services.AddScoped<IReadService<Model.Poslovnica, object>, BaseReadService<Model.Poslovnica, Database.Poslovnica, object>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
