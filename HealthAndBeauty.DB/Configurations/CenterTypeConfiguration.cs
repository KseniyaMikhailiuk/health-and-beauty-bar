using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class CenterTypeConfiguration : IEntityTypeConfiguration<CenterType>
    {
        public void Configure(EntityTypeBuilder<CenterType> builder)
        {
            builder.HasKey(centerType => centerType.Id);

            builder.Property(centerType => centerType.Id)
                .HasColumnName("CenterTypeID");

            builder.HasData(new CenterType[]
            {
                new CenterType() { Id = 1, Name = "Beauty"},
                new CenterType() { Id = 2, Name = "Medical"}
            });
        }
    }
}
