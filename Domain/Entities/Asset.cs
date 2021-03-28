using Domain.Enums;

namespace Domain.Entities
{
    public class Asset : EntityBase
    {
        public string Url { get; set; }
        public AssetType Type { get; set; }
        public string PublicId { get; set; }
    }
}