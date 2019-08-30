using HealthAndBeauty.DB.Configurations;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Umwa.DB
{
    public class HBContext : DbContext
    {
        #region Constructor
        public HBContext(DbContextOptions<HBContext> options)
            : base(options)
        {
        }
        #endregion

        #region Tables Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CenterConfiguration());
            modelBuilder.ApplyConfiguration(new CenterServiceConfiguration());
            modelBuilder.ApplyConfiguration(new CenterTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CenterService> CenterServices { get; set; }
        public DbSet<CenterType> CenterTypes { get; set; }

        #endregion
    }
}
