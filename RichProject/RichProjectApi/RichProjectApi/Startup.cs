using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RichProjectDataAccess;
using Microsoft.AspNetCore.Mvc.Formatters;
using RichProjectApi.Infrastructure;

namespace RichProjectApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // 注册Swagger服务
            services.AddSwaggerGen(c =>
            {
                // 添加文档信息
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "RichProjectApi", Version = "v1" });
            });
            services.AddMvc(option =>
            {
                option.OutputFormatters.RemoveType(typeof(HttpNoContentOutputFormatter));
                option.OutputFormatters.Insert(0, new HttpNoContentOutputFormatter()
                {
                    TreatNullValueAsNoContent = false
                });
                option.Filters.Add(new WebApiExceptionFilterAttribute());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<DataContext>(optionsBuilder => { optionsBuilder.UseSqlServer("Server=.;Database=RichProject;integrated security=true;"); });
            return services.AddAbp<InterfaceModule>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAbp();
            app.UseAbpRequestLocalization();
            app.UseMvc();
            // 启用Swagger中间件
            app.UseSwagger();

            // 配置SwaggerUI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "RichProjectApi");
                c.RoutePrefix = "swagger";
            });
        }
    }
}
