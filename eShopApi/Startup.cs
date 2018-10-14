using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopApi.Bussiness;
using eShopApi.Bussiness.Services;
using eShopApi.Models;
using eShopApi.Repository;
using eShopApi.Repository.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace eShopApi
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
            services.AddMvc();
            var connection = Configuration.GetSection("ConnectionString").Value;
           // var connection = @"Server=localhost;Database=EShop;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<EShopContext>
                (options => options.UseSqlServer(connection));
            services.AddScoped<IProductReopsitory, ProductRepository>();
            services.AddScoped<IUserReopsitory, UserRepository>();
            services.AddScoped<IPurshaseReopsitory, PurshaseRepository>();
            services.AddScoped<IProductImagesReopsitory, ProductImagesRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPurshaseService, PurshaseService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.SeedDatabase();
        }
    }
}
