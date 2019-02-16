using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DemoCoreWebApp.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DemoCoreWebAppContext>
    {
        public DemoCoreWebAppContext CreateDbContext(string[] args)
        {
            //Debugger.Launch();

            // Get environment
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Build config
            IConfiguration config = new ConfigurationBuilder()
                                            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DemoCoreWebApp"))
                                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                            .AddJsonFile($"appsettings.{environment}.json", optional: true)
                                            .AddEnvironmentVariables()
                                            .Build();

            // Get connection string
            var optionsBuilder = new DbContextOptionsBuilder<DemoCoreWebAppContext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("DemoCoreWebApp.Data"));
            return new DemoCoreWebAppContext(optionsBuilder.Options);
        }
    }
}
