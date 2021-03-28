using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class DislikedCandidateConfiguration : IEntityTypeConfiguration<DislikedCandidate>
    {
        public void Configure(EntityTypeBuilder<DislikedCandidate> builder)
        {
            builder.ToTable("DislikedCandidates");
            builder.HasKey(x => new { x.CandidateId, x.FosterProfileId });
        }
    }
}