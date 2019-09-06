using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class WorkingHoursConfiguration : IEntityTypeConfiguration<WorkingHours>
    {
        public void Configure(EntityTypeBuilder<WorkingHours> builder)
        {
            builder.HasKey(wh => new { wh.CenterId, wh.WeekDayId });

            builder.Property(categoty => categoty.CenterId)
                .HasColumnName("CenterID");
            builder.Property(categoty => categoty.WeekDayId)
                .HasColumnName("WeekDayID");
        }
    }
}
