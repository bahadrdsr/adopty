using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ConversationConfiguration : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.ToTable("Conversations");
            builder.HasOne(x => x.FosterUser).WithMany().HasForeignKey(x => x.FosterUserId).IsRequired();
            builder.HasOne(x => x.CandidateUser).WithMany().HasForeignKey(x => x.CandidateUserId).IsRequired();
            builder.HasMany(x => x.Messages).WithOne(z => z.Conversation).HasForeignKey(x => x.ConversationId).IsRequired(true);
        }
    }
}