using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class CandidatePreferenceConfiguration : IEntityTypeConfiguration<CandidatePreference>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CandidatePreference> builder)
        {
            builder.ToTable("CandidatePreferences");
            builder.HasOne(x => x.CandidateProfile).WithOne(z => z.CandidatePreference).HasForeignKey<CandidateProfile>(x => x.CandidatePreferenceId).IsRequired(false);
        }
    }
}