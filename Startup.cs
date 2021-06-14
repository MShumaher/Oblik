using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oblik.Domain;
using Oblik.Domain.Repositories.Abstract;
using Oblik.Domain.Repositories.EntityFramework;
using Oblik.Service;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oblik
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            //Підключаємо конфіг з appsettings.json
            Configuration.Bind("Project", new Config());

            //підключаємо необхідний функціонал додатку в якості сервісів
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<IDoctorsRepository, EFDoctorsRepository>();
            services.AddTransient<IPatientsRepository, EFPatientsRepository>();
            services.AddTransient<IProfsRepository, EFProfsRepository>();
            services.AddTransient<IVisitsRepository, EFVisitsRepository>();
            services.AddTransient<DataManager>();
            
            //підключаємо контекст БД
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //налаштовуємо identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //налаштовуємо authentification cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "oblikAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //налаштовуємо політику авторизації для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //Підключаємо необхідний для роботи функціонал через сервіси
            //додаємо сервіси для контролерів та представлень
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                //встановлюємо сумісність з asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //порядок реєстрації middleware дуже важливий

            //в процесі розробки нам важливо бачити інформацію про помилки
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            //підключаємо підтримку статичних файлів в додатку (css, js і т.д.)
            app.UseStaticFiles();

            //підключаємо систему маршрутизації
            app.UseRouting();

            //підключаємо аутентифікацію та авторизацію
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
