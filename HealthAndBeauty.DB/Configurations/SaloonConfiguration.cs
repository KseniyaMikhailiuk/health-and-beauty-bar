using HealthAndBeauty.DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthAndBeauty.DB.Configurations
{
    public class SaloonConfiguration : IEntityTypeConfiguration<Saloon>
    {
        public void Configure(EntityTypeBuilder<Saloon> builder)
        {
            builder.HasKey(saloon => saloon.Id);
        }
    }
}
