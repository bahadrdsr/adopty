using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class CandidatePreferenceConfiguration : IEntityTypeConfiguration<CandidatePreference>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CandidatePreference> builder)
        {
            builder.ToTable("CandidatePreference");
        }
    }
}