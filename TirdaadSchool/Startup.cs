﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TirdaadSchool.Core.Convertor;
using TirdaadSchool.Core.Services;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Context;

namespace TirdaadSchool
{
    public class Startup
    {


        public IConfiguration configuration { get; set; }

        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/LogOut";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });


            services.AddDbContext<MyDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("TirdaadSchool_ConnectionString"));
            });

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IViewRenderService, RenderViewToString>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
         
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( "areas","{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
             
            });

           

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
