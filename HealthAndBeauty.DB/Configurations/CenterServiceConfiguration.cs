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

            builder.HasData(new CenterService[]
            {
                new CenterService() { Id = 1, CenterId = 1, ServiceId = 1, Price = 110 },
                new CenterService() { Id = 2, CenterId = 1, ServiceId = 2, Price = 120 },
                new CenterService() { Id = 3, CenterId = 1, ServiceId = 9, Price = 1120 },
                new CenterService() { Id = 4, CenterId = 1, ServiceId = 12, Price = 104 },
                new CenterService() { Id = 5, CenterId = 1, ServiceId = 10, Price = 1001 },
                new CenterService() { Id = 6, CenterId = 2, ServiceId = 6, Price = 11230 },
                new CenterService() { Id = 7, CenterId = 2, ServiceId = 4, Price = 100 },
                new CenterService() { Id = 8, CenterId = 2, ServiceId = 6, Price = 100 },
                new CenterService() { Id = 9, CenterId = 2, ServiceId = 7, Price = 100 },
                new CenterService() { Id = 10, CenterId = 2, ServiceId = 12, Price = 100 },
                new CenterService() { Id = 11, CenterId = 2, ServiceId = 1, Price = 100 },
                new CenterService() { Id = 12, CenterId = 2, ServiceId = 2, Price = 100 },
                new CenterService() { Id = 13, CenterId = 3, ServiceId = 8, Price = 100 },
                new CenterService() { Id = 14, CenterId = 3, ServiceId = 6, Price = 100 },
                new CenterService() { Id = 15, CenterId = 3, ServiceId = 5, Price = 100 },
            });
        }
    }
}
