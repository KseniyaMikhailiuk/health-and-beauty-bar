using HealthAndBeauty.DB.Configurations;
using HealthAndBeauty.DB.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Umwa.DB
{
    public class HBContext : IdentityDbContext
    {
        public HBContext(DbContextOptions<HBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CenterConfiguration());
            modelBuilder.ApplyConfiguration(new CenterServiceConfiguration());
            modelBuilder.ApplyConfiguration(new CenterTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CenterService> CenterServices { get; set; }
        public DbSet<CenterType> CenterTypes { get; set; }
    }
}
