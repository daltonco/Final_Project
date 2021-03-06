using Final_Project.Data;
using Final_Project.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project
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

            services.AddDbContext<TallestTsunamisContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TallestTsunamisContext")));
            services.AddScoped<ITsunamiContextDAO, TsunamiContextDAO>();


            services.AddDbContext<StudentsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("StudentsContext")));
            services.AddScoped<IStudentsContextDAO, StudentsContextDAO>();

            services.AddDbContext<MountainsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MountainsContext")));
            services.AddScoped<IMountainsContextDAO, MountainsContextDAO>();
      
            services.AddDbContext<SportsTeamsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SportsTeamsContext")));
            services.AddScoped<ISportsContextDAO, SportsContextDAO>();

            services.AddSwaggerDocument();
        }


      

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TallestTsunamisContext context, StudentsContext context2, MountainsContext context3, SportsTeamsContext context4)

        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            context.Database.Migrate();

            context.Database.Migrate();
            context2.Database.Migrate();
            context3.Database.Migrate();
            context4.Database.Migrate();

            app.UseOpenApi();
            app.UseSwaggerUi3();

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