using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FosterPreferencesConfiguration : IEntityTypeConfiguration<FosterPreferences>
    {
        public void Configure(EntityTypeBuilder<FosterPreferences> builder)
        {
            builder.ToTable("FosterPreferences");
            builder.HasOne(x => x.FosterProfile).WithOne(z => z.FosterPreferences).HasForeignKey<FosterProfile>(x => x.AppUserId).IsRequired(false);
        }
    }
}