using System;
using MediatR;

namespace Application.FosterPosts.Commands.RemoveFosterPostAsset
{
    public class RemoveFosterPostAssetCommand : IRequest
    {
        public Guid AssetId { get; set; }
        public Guid FosterPostId { get; set; }
    }
}