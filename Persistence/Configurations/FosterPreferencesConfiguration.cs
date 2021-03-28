using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FosterPreferenceConfiguration : IEntityTypeConfiguration<FosterPreference>
    {
        public void Configure(EntityTypeBuilder<FosterPreference> builder)
        {
            builder.ToTable("FosterPreference");
            builder.HasOne(x => x.FosterProfile).WithOne(z => z.FosterPreference).HasForeignKey<FosterProfile>(x => x.AppUserId).IsRequired(false);
        }
    }
}