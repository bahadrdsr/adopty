using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configurations
{
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Assets");
            builder.Property(x => x.PublicId).HasMaxLength(1024).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(1024).IsRequired();
            builder.Property(x => x.Type).IsRequired();
        }
    }
}