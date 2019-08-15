using HealthAndBeauty.DB.Configurations;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthAndBeauty.DB
{
    public class HBContext: DbContext
    {
        public HBContext(DbContextOptions<HBContext> options)
            : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SaloonConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Saloon> Saloons { get; set; }
    }
}
