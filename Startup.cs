using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

using Npgsql.EntityFrameworkCore;

using TriNimbus_SimpleAPI.Models;

namespace TriNimbus_SimpleAPI
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

            //var connection = Configuration.GetSection("Data").GetSection("ConnectionString").Value;
            var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            var dbUser = Environment.GetEnvironmentVariable("DB_USER");
            var dbPass = Environment.GetEnvironmentVariable("DB_PASS");
            var dbName = Environment.GetEnvironmentVariable("DB_NAME");

            var connectionStr = string.Format("Host={0};Port={1};User ID={2};Password={3};Database={4};Pooling=true;", dbHost, dbPort, dbUser, dbPass, dbName);
            Console.WriteLine();
            Console.Write("DB Conn str: "+ connectionStr);
            Console.WriteLine();

            services.AddDbContext<AccountContext>(options => options.UseNpgsql(connectionStr));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
