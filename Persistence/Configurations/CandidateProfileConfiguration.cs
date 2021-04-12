using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CandidateProfileConfiguration : ProfileConfiguration<CandidateProfile>
    {
        public void Configure(EntityTypeBuilder<CandidateProfile> builder)
        {
            builder.ToTable("CandidateProfiles");
            
            builder.HasOne(x => x.CandidatePreference).WithOne(z => z.CandidateProfile).HasForeignKey<CandidateProfile>(x=>x.CandidatePreferenceId).IsRequired(false);
            builder.HasMany(x=>x.LikedPosts).WithOne(z=>z.CandidateProfile).HasForeignKey(x=>x.CandidateProfileId).IsRequired(true);
            builder.HasMany(x=>x.DislikedPosts).WithOne(z=>z.CandidateProfile).HasForeignKey(x=>x.CandidateProfileId).IsRequired(true);
        }
    }
}