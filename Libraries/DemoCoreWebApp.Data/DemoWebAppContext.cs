using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DemoCoreWebApp.Data
{
    public class DemoCoreWebAppContext : DbContext
    {
        public DemoCoreWebAppContext(DbContextOptions<DemoCoreWebAppContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
        }
    }
}
