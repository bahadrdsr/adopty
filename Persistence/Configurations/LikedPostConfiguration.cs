using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class LikedPostConfiguration : IEntityTypeConfiguration<LikedPost>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LikedPost> builder)
        {
            builder.ToTable("LikedPosts");
            builder.HasKey(x => new { x.PostId, x.CandidateProfileId });
        }
    }
}