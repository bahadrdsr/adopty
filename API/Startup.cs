using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Photos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;
using Persistence;

namespace API
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

            services.AddCors(opt =>
                   {
                       opt.AddPolicy("CorsPolicy", policy =>
                       {
                           policy
                               .AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowAnyOrigin();
                       });
                   });
            services.AddControllers().AddNewtonsoftJson(options =>
                  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
             );
            services.AddIdentity<AppUser, IdentityRole>().AddRoles<IdentityRole>().AddEntityFrameworkStores<DataContext>();
            services.AddDbContext<DataContext>(opt =>
         {
             opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
         });
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokenKey"]));
            services.AddAuthentication(x =>
             {
                 x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                 x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
             })
             .AddJwtBearer(x =>
             {
                 x.RequireHttpsMetadata = false;
                 x.SaveToken = true;
                 x.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = key,
                     ValidateIssuer = false,
                     ValidateAudience = false
                 };
                 x.Events = new JwtBearerEvents
                 {
                     OnMessageReceived = context =>
                     {
                         var accessToken = context.Request.Query["access_token"];
                         var path = context.HttpContext.Request.Path;
                         if (!string.IsNullOrEmpty(accessToken) && (path.StartsWithSegments("/notification")))
                         {
                             context.Token = accessToken;
                         }

                         return Task.CompletedTask;
                     }
                 };
             });
            services.AddAuthentication();
            services.AddOpenApiDocument(configure =>
          {
              configure.Title = "LProject API";
              configure.AddSecurity("JWT", Enumerable.Empty<string>(), new OpenApiSecurityScheme
              {
                  Type = OpenApiSecuritySchemeType.ApiKey,
                  Name = "Authorization",
                  In = OpenApiSecurityApiKeyLocation.Header,
                  Description = "Type into the textbox: Bearer {your JWT token}."
              });

              configure.OperationProcessors.Add(
                  new AspNetCoreOperationSecurityScopeProcessor("JWT"));
          });
            services.AddInfrastructure();
            services.AddApplication();
            services.Configure<CloudinarySettings>(Configuration.GetSection("Cloudinary"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOpenApi();
            app.UseCors("CorsPolicy");
            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/swagger";
                //    settings.DocumentPath = "/api/specification.json";   Enable when NSwag.MSBuild is upgraded to .NET Core 3.0
            });
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
