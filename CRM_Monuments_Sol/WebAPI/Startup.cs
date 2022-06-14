using DataLayer;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Implementations;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using VueCliMiddleware;

namespace WebAPI
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
            services.AddDbContext<EFDBContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<EFDBContext>().AddDefaultTokenProviders();//.AddDefaultUI();

            services.AddTransient<IContractsRepository, EFContractsRepository>();
            services.AddTransient<ICustomersRepository, EFCustomersRepository>();
            services.AddTransient<IDeceasedsRepository, EFDeceasedsRepository>();
            services.AddTransient<IPhotosOnMonumentsRepository, EFPhotosOnMonumentsRepository>();
            services.AddTransient<IApplicationUsersRepository, EFApplicationUsersRepository>();
            services.AddTransient<ITypesPortraitRepository, EFTypesPortraitRepository>();
            services.AddTransient<ITypesTextsRepository, EFTypesTextsRepository>();
            services.AddTransient<IMedallionMaterialsRepository, EFMedallionMaterialsRepository>();
            services.AddTransient<IShapeMedallionsRepository, EFShapeMedallionsRepository>();
            services.AddTransient<IStellaRepository, EFStellaRepository>();
            services.AddTransient<ITextOnStellaRepository, EFTextOnStellaRepository>();
            services.AddTransient<IEpitaphRepository, EFEpitaphRepository>();

            services.AddScoped<DataManager>();

            services.AddControllers();
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp";
            });

            //services.Configure<WebEncoderOptions>(options =>
            //{
            //    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env, EFDBContext context,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseSpaStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            DBInitializer.Seed(context, userManager, roleManager).GetAwaiter().GetResult();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=WeatherForecast}/{action=Get}");///{id?}
            //    //endpoints.MapRazorPages();
            //});

            app.UseSpa(spa =>
            {
                if (env.IsDevelopment())
                    spa.Options.SourcePath = "ClientApp/";
                else
                    spa.Options.SourcePath = "dist";

                if (env.IsDevelopment())
                {
                    spa.UseVueCli(npmScript: "serve");
                }
                spa.UseProxyToSpaDevelopmentServer("http://localhost:50598");
            });
        }
    }
}
