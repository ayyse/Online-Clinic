using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Online_Clinic.Common.ConstantsModels;
using Online_Clinic.Common.EmailOperationModels;
using Online_Clinic.Common.Mappings;
using Online_Clinic.Data.Concrats;
using Online_Clinic.Data.DataContext;
using Online_Clinic.Data.DbModels;
using Online_Clinic.Data.Implementation;
using Online_Clinic.Services.Contracts;
using Online_Clinic.Services.Implementation;
using System;

namespace Online_Clinic
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
            services.AddDbContext<ClinicContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddAutoMapper(typeof(Maps));

            //services.AddSingleton<IEmailSender, EmailSender>();
            //services.Configure<EmailOptions>(Configuration);

            services.AddScoped<IRandevuService, RandevuService>();
            services.AddScoped<ITalepService, TalepService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDoktorService, DoktorService>();
            services.AddScoped<IHastaService, HastaService>();
            services.AddScoped<IBaðýþçýService, BaðýþçýService>();
            services.AddScoped<IHikayeService, HikayeService>();




            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();

            services.AddIdentity<Visitor, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ClinicContext>();

            services.AddMvc();
            services.AddSession(options => 
            {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });

            //services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddDbContext<AppDbContext>
            //    (o => o.UseSqlServer(Configuration.GetConnectionString("MyNewDatabase")));
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<Visitor> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Home/Error");
                //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //    name: "default",
            //    template: "{Controller=Home}/{action=Index}");
            //});

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            SeedData.Seed(userManager, roleManager);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                
            });
        }
    }
}