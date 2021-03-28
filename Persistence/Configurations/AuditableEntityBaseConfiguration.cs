using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AuditableEntityBaseConfiguration<T> : EntityBaseConfiguration<T> where T : AuditableEntityBase
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasOne(e => e.CreatedBy).WithMany().HasForeignKey(e => e.CreatedById).IsRequired();
            builder.HasOne(e => e.ModifiedBy).WithMany().HasForeignKey(e => e.ModifiedById).IsRequired(false);
        }
    }
}