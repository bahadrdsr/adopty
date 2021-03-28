using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.Property(x => x.Info).HasMaxLength(2048).IsRequired(false);
            // builder.HasOne(x => x.AppUser).WithOne(z => z.FosterProfile).HasForeignKey<AppUser>(x => x.FosterProfileId).IsRequired(false);
            // builder.HasOne(x => x.AppUser).WithOne(z => z.CandidateProfile).HasForeignKey<AppUser>(x => x.CandidateProfileId).IsRequired(false);
            builder.HasMany(x => x.Photos).WithOne(z => z.Profile).HasForeignKey(x => x.ProfileId).IsRequired(false);
        }
    }
}