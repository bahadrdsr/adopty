using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
            builder.HasOne(x => x.Country).WithMany(z => z.Cities).HasForeignKey(x => x.CountryId).IsRequired();
        }
    }
}