using DataLayer;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Implementations;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace PresentationLayer
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
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
            });

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
            }).AddEntityFrameworkStores<EFDBContext>().AddDefaultTokenProviders().AddDefaultUI();

            services.AddTransient<IContractsRepository, EFContractsRepository>();
            services.AddTransient<ICustomersRepository, EFCustomersRepository>();
            services.AddTransient<IDeceasedsRepository, EFDeceasedsRepository>();
            services.AddTransient<IPhotosOnMonumentsRepository, EFPhotosOnMonumentsRepository>();
            services.AddTransient<IApplicationUsersRepository, EFApplicationUsersRepository>();
            services.AddTransient<ITypesPortraitRepository, EFTypesPortraitRepository>();
            services.AddTransient<ITypesTextsRepository, EFTypesTextsRepository>();
            services.AddTransient<IMedallionMaterialsRepository, EFMedallionMaterialsRepository>();
            services.AddTransient<IShapeMedallionsRepository, EFShapeMedallionsRepository>();
            services.AddTransient<IEpitaphRepository, EFEpitaphRepository>();
            services.AddTransient<IStellaRepository, EFStellaRepository>();
            services.AddTransient<ITextOnStellaRepository, EFTextOnStellaRepository>();

            services.AddScoped<DataManager>();

            //????? ???????????? ??????? ?? ???????????? ? ??????????????? Unicode Hex Character Code
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IWebHostEnvironment env, EFDBContext context,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            DBInitializer.Seed(context, userManager, roleManager).GetAwaiter().GetResult();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
