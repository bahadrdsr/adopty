using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class LikedCandidateConfiguration : IEntityTypeConfiguration<LikedCandidate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LikedCandidate> builder)
        {
            builder.ToTable("LikedCandidates");
            builder.HasKey(x => new { x.CandidateProfileId, x.FosterProfileId });
        }
    }
}