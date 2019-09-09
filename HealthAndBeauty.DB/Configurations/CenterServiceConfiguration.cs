using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class CenterServiceConfiguration : IEntityTypeConfiguration<CenterService>
    {
        public void Configure(EntityTypeBuilder<CenterService> builder)
        {
            builder.HasKey(centerService => centerService.Id);

            builder.Property(centerService => centerService.Id)
                .HasColumnName("CenterServiceID");
            builder.Property(centerService => centerService.CenterId)
                .HasColumnName("CenterID");
            builder.Property(centerService => centerService.ServiceId)
                .HasColumnName("ServiceID");

            builder.HasOne(cs => cs.Center)
                .WithMany(c => c.CenterServices)
                .HasForeignKey(cs => cs.CenterId);

            builder.HasOne(cs => cs.Service)
                .WithMany(s => s.CenterServices)
                .HasForeignKey(cs => cs.ServiceId);
        }
    }
}
