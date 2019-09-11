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

            builder.HasData(new Category[]
            {
                new Category() { Id = 1, Name = "CategoryA" },
                new Category() { Id = 2, Name = "CategoryB" },
                new Category() { Id = 3, Name = "CategoryC" },
                new Category() { Id = 4, Name = "CategoryD" },
                new Category() { Id = 5, Name = "CategoryE" },
            });
        }
    }
}
