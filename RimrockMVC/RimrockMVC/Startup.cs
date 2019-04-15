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
using RimrockMVC.Data;
using RimrockMVC.Models.Interfaces;
using RimrockMVC.Models.Services;

namespace RimrockMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IHostingEnvironment Environment { get; }

        /// <summary>
        /// Constructor to build out MVC Startup
        /// </summary>
        /// <param name="configuration">The Configuration is actually not used it is just a dummy to get access to the Environment.</param>
        /// <param name="environment">The Environment is applied to the instance Environment.</param>
        public Startup (IConfiguration configuration, IHostingEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables().AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Environment.IsDevelopment()
                ? Configuration["ConnectionString:Default"]
                : Configuration["ConnectionString:Production"];
            services.AddMvc();
            services.AddDbContext<RimrockDBContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUserManager, UserService>();
            //services.AddScoped<IRetailerManager, RetailerService>();
            //services.AddScoped<ILocationManager, LocationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Controls the routing
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Allows use of files in wwwroot folder
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
