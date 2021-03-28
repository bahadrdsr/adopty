using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AnimalSpeciesConfiguration : IEntityTypeConfiguration<AnimalSpecie>
    {
        public void Configure(EntityTypeBuilder<AnimalSpecie> builder)
        {
            builder.ToTable("AnimalSpecies");
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(true);
        }
    }
}