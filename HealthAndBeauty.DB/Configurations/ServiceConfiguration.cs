using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(service => service.Id);

            builder.Property(service => service.Id)
                .HasColumnName("ServiceID");

            builder.Property(service => service.CategoryId)
                .HasColumnName("CategoryID");

            builder.HasOne(s => s.Category)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.CategoryId);

            builder.HasData(new Service[]
            {
                new Service() { Id = 1, Name = "ServiceA", CategoryId = 1 },
                new Service() { Id = 2, Name = "ServiceB", CategoryId = 2 },
                new Service() { Id = 3, Name = "ServiceC", CategoryId = 3 },
                new Service() { Id = 4, Name = "ServiceD", CategoryId = 1 },
                new Service() { Id = 5, Name = "ServiceE", CategoryId = 2 },
                new Service() { Id = 6, Name = "ServiceF", CategoryId = 3 },
                new Service() { Id = 7, Name = "ServiceG", CategoryId = 4 },
                new Service() { Id = 8, Name = "ServiceH", CategoryId = 5 },
                new Service() { Id = 9, Name = "ServiceI", CategoryId = 4 },
                new Service() { Id = 10, Name = "ServiceJ", CategoryId = 5 },
                new Service() { Id = 11, Name = "ServiceK", CategoryId = 1 },
                new Service() { Id = 12, Name = "ServiceL", CategoryId = 2 },
                new Service() { Id = 13, Name = "ServiceM", CategoryId = 3 },
                new Service() { Id = 14, Name = "ServiceN", CategoryId = 4 },
                new Service() { Id = 15, Name = "ServiceO", CategoryId = 5 }
            });
        }
    }
}
