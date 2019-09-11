using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class CenterConfiguration : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> builder)
        {
            builder.HasKey(center => center.Id);

            builder.Property(center => center.Id)
                .HasColumnName("CenterID");
            builder.Property(center => center.CenterTypeId)
                .HasColumnName("CenterTypeID");

            builder.HasOne(c => c.CenterType)
                .WithMany(ct => ct.Centers)
                .HasForeignKey(c => c.CenterTypeId);

            builder.HasMany(c => c.WorkingHours)
                .WithOne(wh => wh.Center)
                .HasForeignKey(c => c.CenterId);

            builder.HasData(new Center[]
            {
                new Center(){ Id = 1, Name ="CenterA", CenterTypeId = 1, MainImageUrl = "https://picsum.photos/id/237/200/300"},
                new Center(){ Id = 2, Name ="CenterB", CenterTypeId = 1, MainImageUrl = "https://picsum.photos/id/237/200/300"},
                new Center(){ Id = 3, Name ="CenterC", CenterTypeId = 2, MainImageUrl = "https://picsum.photos/id/237/200/300"},
            });
        }
    }
}
