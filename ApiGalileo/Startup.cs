using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using System;
using NLog.Web;
using ApiGalileo.Exception;
using ApiGalileo.Helpers;
using Domain.Metafase.Model;
using Domain.Identity;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;

namespace ApiGalileo
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="env"></param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
              .AddEnvironmentVariables();
            env.ConfigureNLog("nlog.config");
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSingleton(_ => Configuration);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddDbContext<Metafase>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MetafaseConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRoles>()
               .AddEntityFrameworkStores<ApplicationDbContext>()
               .AddDefaultTokenProviders();


            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ApiValidationFilterAttribute));

            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateIssuer = false,
                         ValidateAudience = false,
                         ValidateLifetime = true,
                         ValidateIssuerSigningKey = true,
                         IssuerSigningKey = new SymmetricSecurityKey(
                         Encoding.UTF8.GetBytes(Configuration["jwt:key"])),
                         ClockSkew = TimeSpan.Zero
                     });
            IoC.RegisterSRServices(services);

            services.AddSwaggerGen(c => { 
                c.SwaggerDoc("v1", new Info { 
                        Title = "Galileo" ,
                        Version = "v1"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);

                c.EnableAnnotations();
            });

           

            

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("v1/swagger.json","Api Galileo");
                //c.RoutePrefix = "";
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.ConfigureCustomExceptionMiddleware();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200", "https://app.metafase.com").AllowAnyMethod().WithHeaders("*"));
            /// app.UseCors(builder => builder.WithOrigins("https://app.metafase.com", "http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
