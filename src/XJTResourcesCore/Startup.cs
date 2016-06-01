using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XJTResourcesCore.Data;
using XJTResourcesCore.Models;
using XJTResourcesCore.Services;
using OpenIddict.Models;
using OpenIddict;
using XJTResourcesCore.Infrastructure;
using XJTResourcesCore.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AspNet.Security.OpenIdConnect.Extensions;
using XJTResourcesCore.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using AspNet.Security.OAuth.Validation;

namespace XJTResourcesCore
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddOpenIddictCore<Application>(config => config.UseEntityFramework());

            services.Configure<SharedAuthenticationOptions>(options => {
                options.SignInScheme = "ServerCookie";
            });

            services.AddAuthentication();

            services.AddAuthorization(options => {


            options.AddPolicy(
                "Bearer", policy => {

                    policy.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                        .RequireAuthenticatedUser()
                        .Build();

                    });
            });

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddTransient<IDatabaseInitializer, DatabaseInitializer>();
            services.AddScoped<OpenIddictManager<ApplicationUser, Application>, CustomOpenIddictManager>();
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            ILoggerFactory loggerFactory, IDatabaseInitializer databaseInitializer)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIdentity();


            app.UseWhen(context => context.Request.Path.StartsWithSegments(new PathString("/api")), branch =>
            {
                branch.UseOAuthValidation(new OAuthValidationOptions
                {
                    AutomaticAuthenticate = true,
                    AutomaticChallenge = true
                });
            });

                app.UseWhen(context => !context.Request.Path.StartsWithSegments(new PathString("/api")), branch =>
            {

                branch.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AutomaticAuthenticate = true,
                    AutomaticChallenge = true,
                    AuthenticationScheme = "ServerCookie",
                    CookieName = CookieAuthenticationDefaults.CookiePrefix + "ServerCookie",
                    AccessDeniedPath = new PathString("/Account/Forbidden"),
                    ExpireTimeSpan = TimeSpan.FromMinutes(5),
                    LoginPath = new PathString("/Account/Login"),
                    LogoutPath = new PathString("/Account/LogOff")
                });
            });


            app.UseOpenIdConnectServer(builder =>
            {

                builder.Issuer = new Uri("http://localhost:5000");
                builder.AllowInsecureHttp = true;
                builder.AuthorizationEndpointPath = PathString.Empty;
                builder.Provider = new AuthorizationProvider();
                builder.UseJwtTokens();

            });

            app.UseJwtBearerAuthentication(new JwtBearerOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                RequireHttpsMetadata = false,
                Audience = "resource_server",
                Authority = "http://localhost:5000"
            });

         

            app.UseStaticFiles();
            

            app.UseOpenIddict();

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller}/{action}",
                    defaults: new { action = "Index" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default_api",
                    template: "api/{controller}/{id?}");
            });

            await databaseInitializer.Seed();

            //using (var database = app.ApplicationServices.GetService<ApplicationDbContext>())
            //{
            //    database.Applications.Add(new Application
            //    {
            //        Id = "XJTResourcesClient",
            //        DisplayName = "XJTResources",
            //        RedirectUri = "http://locahost:5000/signin-oidc",
            //        LogoutRedirectUri = "http://localhost:5000",
            //        Secret = "Super_Dooper_Secret"
            //    });

            //    database.SaveChanges();
            //}
        }
    }
}
