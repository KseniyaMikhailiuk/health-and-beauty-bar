using HealthAndBeauty.DB.Configurations;
using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace HealthAndBeauty.DB
{
    public class HBContext : DbContext
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
