using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAndBeauty.DB.Configurations
{
    public class CenterServiceConfiguration : IEntityTypeConfiguration<CenterService>
    {
        public void Configure(EntityTypeBuilder<CenterService> builder)
        {
            builder.HasKey(centerService => new { centerService.ServiceId, centerService.CenterId });

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
