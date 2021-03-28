using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class ProfileAssetConfiguration : IEntityTypeConfiguration<ProfileAsset>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProfileAsset> builder)
        {
            builder.ToTable("ProfileAssets");
            builder.HasKey(x => new { x.ProfileId, x.AssetId });
        }
    }
}