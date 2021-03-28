using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class DislikedPostConfiguration : IEntityTypeConfiguration<DislikedPost>
    {
        public void Configure(EntityTypeBuilder<DislikedPost> builder)
        {
            builder.ToTable("DislikedPosts");
            builder.HasKey(x => new { x.CandidateProfileId, x.PostId });
        }
    }
}