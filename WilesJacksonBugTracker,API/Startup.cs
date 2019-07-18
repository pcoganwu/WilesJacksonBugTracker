﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WilesJacksonBugTracker.Repository.Domain;

namespace WilesJacksonBugTracker_API
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
           services.AddDbContext<BugContext>(Options =>
           Options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Add Cors
            //services.AddCors(o => o.AddPolicy("BugPolicy", builder =>
            //{
            //    builder.AllowAnyOrigin()
            //    .AllowAnyMethod()
            //    .AllowAnyHeader();
            //}));

            services.AddCors(o =>
            {
                o.AddPolicy("BugPolicy", options =>
                options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1,0); //assume default version if now version specified
                options.ApiVersionReader = new MediaTypeApiVersionReader(); //where to find API version information
                options.AssumeDefaultVersionWhenUnspecified = true; //if now version specified, assume the default version is true
                options.ReportApiVersions = true; //report API version
                options.ApiVersionSelector = new CurrentImplementationApiVersionSelector(options);//specify version selector
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors();
        }
    }
}
