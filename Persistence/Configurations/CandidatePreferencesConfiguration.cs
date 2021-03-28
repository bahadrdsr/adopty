using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class CandidatePreferencesConfiguration : IEntityTypeConfiguration<CandidatePreferences>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CandidatePreferences> builder)
        {
            builder.ToTable("CandidatePreferences");
        }
    }
}