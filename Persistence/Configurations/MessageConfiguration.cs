using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");
            builder.Property(x => x.Text).HasMaxLength(512).IsRequired();
            builder.HasOne(x => x.Sender).WithMany().HasForeignKey(x => x.SenderId).IsRequired();
            builder.HasOne(x => x.Recipent).WithMany().HasForeignKey(x => x.RecipentId).IsRequired();
            builder.HasOne(x => x.Conversation).WithMany(z => z.Messages).HasForeignKey(x => x.ConversationId).IsRequired();
        }
    }
}