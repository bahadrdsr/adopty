using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FosterPostConfiguration : IEntityTypeConfiguration<FosterPost>
    {
        public void Configure(EntityTypeBuilder<FosterPost> builder)
        {
            builder.ToTable("FosterPosts");
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(1024).IsRequired(false);
            builder.HasOne(x => x.Specie).WithMany().HasForeignKey(x => x.SpeciesId).IsRequired(false);
            builder.HasOne(x => x.FosterProfile).WithMany().HasForeignKey(x => x.FosterProfileId).IsRequired(false);
        }
    }
}