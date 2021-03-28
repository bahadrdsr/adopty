using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.ToTable("Matches");
            builder.HasOne(x => x.FosterUser).WithMany().HasForeignKey(x => x.FosterUserId).IsRequired();
            builder.HasOne(x => x.CandidateUser).WithMany().HasForeignKey(x => x.CandidateUserId).IsRequired();
            builder.HasOne(x => x.Post).WithMany().HasForeignKey(x => x.PostId).IsRequired(false);
        }
    }
}