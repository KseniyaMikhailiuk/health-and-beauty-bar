using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(categoty => categoty.Id);

            builder.Property(categoty => categoty.Id)
                .HasColumnName("CategotyID");
        }
    }
}
