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

		/// <summary>
		/// Adds middleware services and mappings between interfaces and services for repository design pattern
		/// </summary>
		/// <param name="services">Service to inject as dependency</param>
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Environment.IsDevelopment()
                ? Configuration["ConnectionStrings:Default"]
                : Configuration["ConnectionStrings:Production"];

			services.AddMvc();
            services.AddDbContext<RimrockDBContext>(options => options.UseSqlServer(connectionString));

			// Mappings between interfaces and the services that implement them
			services.AddScoped<IUserManager, UserService>();
            services.AddScoped<IFavRetailerManager, FavRetailerService>();
            services.AddScoped<IFavLocationManager, FavLocationService>();
        }

		/// <summary>
		/// This method gets called by the runtime and is used to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="app">Class that provides mechanisms to configure app's request pipeline</param>
		/// <param name="env">Web hosting environment</param>
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

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
