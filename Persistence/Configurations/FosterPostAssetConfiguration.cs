using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FosterPostAssetConfiguration : IEntityTypeConfiguration<FosterPostAsset>
    {
        public void Configure(EntityTypeBuilder<FosterPostAsset> builder)
        {
            builder.ToTable("FosterPostAssets");
            builder.HasKey(x => new { x.PostId, x.AssetId });
        }
    }
}