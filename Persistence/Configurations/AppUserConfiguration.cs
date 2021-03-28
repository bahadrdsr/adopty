using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable(name: "Users");
            builder.HasOne(x => x.FosterProfile).WithOne(z => z.AppUser).HasForeignKey<FosterProfile>(x => x.AppUserId).IsRequired(false);
            builder.HasOne(x => x.CandidateProfile).WithOne(z => z.AppUser).HasForeignKey<CandidateProfile>(x => x.AppUserId).IsRequired(false);
        }
    }
}