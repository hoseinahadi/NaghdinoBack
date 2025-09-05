using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyResolving;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace AppleShopWebApi
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
            
            services.AddMvc()
                .AddSessionStateTempDataProvider();
            services.AddSession();
            var x = Configuration["ConnectionString"];
            Dependency.dependency(services, x);
            services.AddControllersWithViews();
            services.AddHsts(op =>
            {
                op.MaxAge = TimeSpan.FromDays(365);
                op.IncludeSubDomains = true;
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AppleShopWebApi", Version = "v1" });
            });
            var secretKey = Configuration.GetValue<string>("TokenKey");
            var tokenTimeOut = Configuration.GetValue<int>("TokenTimeOut");
            var key = System.Text.Encoding.UTF8.GetBytes(secretKey);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ClockSkew = TimeSpan.FromMinutes(tokenTimeOut),
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });
            services.AddHttpContextAccessor();
            services.AddCors(option =>
            {
                //use from limited request from other url
                //option.AddPolicy("CompanyA", builder =>
                //{
                //    builder.WithOrigins("Url").WithHeaders().WithMethods();
                //});
                //bottom code use unlimited
                option.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://192.168.100.3:8081", "http://192.168.100.3:8082", "http://192.168.100.3:8083")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    

                });
                option.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("exp://192.168.100.3:8081 ")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    

                });



            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppleShopWebApi v1"));

                
            

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
