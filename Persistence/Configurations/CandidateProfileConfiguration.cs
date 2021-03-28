using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CandidateProfileConfiguration : IEntityTypeConfiguration<CandidateProfile>
    {
        public void Configure(EntityTypeBuilder<CandidateProfile> builder)
        {
            builder.ToTable("CandidateProfiles");
            
            builder.HasOne(x => x.CandidatePreferences).WithOne(z => z.CandidateProfile).HasForeignKey<CandidateProfile>(x=>x.CandidatePreferencesId).IsRequired(false);
            builder.HasMany(x=>x.LikedPosts).WithOne(z=>z.CandidateProfile).HasForeignKey(x=>x.CandidateProfileId).IsRequired(true);
            builder.HasMany(x=>x.DislikedPosts).WithOne(z=>z.CandidateProfile).HasForeignKey(x=>x.CandidateProfileId).IsRequired(true);
        }
    }
}