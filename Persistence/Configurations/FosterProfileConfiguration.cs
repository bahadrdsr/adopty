using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FosterProfileConfiguration : IEntityTypeConfiguration<FosterProfile>
    {

        public void Configure(EntityTypeBuilder<FosterProfile> builder)
        {
            builder.ToTable("FosterProfiles");
            
            builder.HasOne(x => x.FosterPreference).WithOne(z => z.FosterProfile).HasForeignKey<FosterProfile>(x=>x.FosterPreferenceId).IsRequired(false);
            builder.HasMany(x => x.Posts).WithOne(z => z.FosterProfile).HasForeignKey(x => x.FosterProfileId).IsRequired(false);
            builder.HasMany(x => x.LikedCandidates).WithOne(z => z.FosterProfile).HasForeignKey(x => x.FosterProfileId).IsRequired(false);
            builder.HasMany(x => x.DislikedCandidates).WithOne(z => z.FosterProfile).HasForeignKey(x => x.FosterProfileId).IsRequired(false);
        }
    }
}