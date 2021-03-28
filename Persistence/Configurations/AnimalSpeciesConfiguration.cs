using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AnimalSpeciesConfiguration : IEntityTypeConfiguration<AnimalSpecies>
    {
        public void Configure(EntityTypeBuilder<AnimalSpecies> builder)
        {
            builder.ToTable("AnimalSpecies");
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(true);
        }
    }
}