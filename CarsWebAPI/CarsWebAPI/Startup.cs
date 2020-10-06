using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsWebAPI.Context;
using CarsWebAPI.Service;
using CarsWebAPI.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CarsWebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("appsettings.json");
            Configuration = config.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CarsWebAPIContext>(builder =>
                builder.UseSqlServer(Configuration.GetConnectionString("SQL")));

            
            services.AddControllers();
            services.AddScoped<ICarService, CarService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
