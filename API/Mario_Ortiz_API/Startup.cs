using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // vrs.mortiz
using Microsoft.EntityFrameworkCore.SqlServer; // vrs mfortiz
using Mario_Ortiz_API.Models; // vrs.mfortiz
using Microsoft.EntityFrameworkCore.Infrastructure;
using Mario_Ortiz_API.Controllers.ViewModel;
using Mario_Ortiz_API.Controllers.ViewModel.Editorial; 
using Mario_Ortiz_API.Controllers.ViewModel.Autor;
using Mario_Ortiz_API.Controllers.ViewModel.Libro;

namespace Mario_Ortiz_API
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
            // cadena de conexion vrs.0001
            services.AddDbContextPool<_DbContex>(
                options => options.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            


            // Inyeccion De Dependencia
            services.AddScoped<IEditorialService, EditorialService>();
            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<ILibroService, LibroService>();

            services.AddCors(options => options.AddPolicy("AllowWebApp", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            services.AddMvc();


            services.AddControllers();

            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mario_Ortiz_API", Version = "v1" });
            });




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {

                app.UseCors("AllowWebApp");

                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                //
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mario_Ortiz_API v1"));


                app.UseSwaggerUI(options => { options.DefaultModelsExpandDepth(-1); });
            }

            
       



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
