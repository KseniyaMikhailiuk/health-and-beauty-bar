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
        }
    }
}
