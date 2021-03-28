using System;

namespace Domain.Entities
{
    public class ProfileAsset
    {
        public Guid ProfileId { get; set; }

        public Profile Profile { get; set; }

        public Guid AssetId { get; set; }
        public Asset Asset { get; set; }

    }
}