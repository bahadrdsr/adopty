using System;

namespace Domain.Entities
{
    public class FosterPostAsset
    {
        public Guid PostId { get; set; }
        public FosterPost Post { get; set; }

        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }
    }
}