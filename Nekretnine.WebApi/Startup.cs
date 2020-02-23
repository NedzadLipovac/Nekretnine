using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarHireRC.WebAPI.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Nekretnine.Model.Requests;
using Nekretnine.WebApi.Database;
using Nekretnine.WebApi.Services;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Nekretnine.WebApi
{
    public class Startup
    {
        public class BasicAuthDocumentFilter : IDocumentFilter
        {
            public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
            {
                var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

                swaggerDoc.Security = new[] { securityRequirements };
            }
        }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
             .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKlijentiService, KlijentiService>();
            services.AddScoped<IGenerateHashHelper, GenerateHashHelperService>();
            services.AddScoped<IService<Model.Models.Grad, Model.Requests.GradSearchRequest>, BaseService<Model.Models.Grad, Model.Requests.GradSearchRequest, Database.Grad>>();
            services.AddScoped<ICRUDService<Model.Models.Sastanak, SastanakSearchRequest, SastanakUpsertRequest, SastanakUpsertRequest>, SastanciService>();
            services.AddScoped<ICRUDService<Model.Models.UpitZaSastanak, object, UpitZaSastanakUpsertRequest, UpitZaSastanakUpsertRequest>, UpitiZaSastankeService>();
            services.AddScoped<ICRUDService<Model.Models.Nekretnina, NekretninaSearchRequest, NekretninaUpsertRequest, NekretninaUpsertRequest>, NekretnineService>();
            services.AddScoped<ICRUDService<Model.Models.Slika, SlikaSearchRequest, SlikaUpsertRequest, SlikaUpsertRequest>, SlikeService>();
            services.AddScoped<ICRUDService<Model.Models.Komentar, KomentarSearchRequest, KomentarUpsertRequest, KomentarUpsertRequest>, KomentarService>();
            services.AddScoped<ICRUDService<Model.Models.Poruka, PorukaSearchRequest, PorukaUpsertRequest, PorukaUpsertRequest>, PorukaService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            var connection = @"Server=.;Database=Nekretnine;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<NekretnineContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request 69.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

           // app.UseHttpsRedirection();
            app.UseMvc();


           
        }
    }
}
