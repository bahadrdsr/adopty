using System;
using MediatR;

namespace Application.FosterPosts.Commands.AddFosterPostAsset
{
    public class AddFosterPostAssetCommand : IRequest
    {
        public Guid AssetId { get; set; }
        public Guid FosterPostId { get; set; }
    }
}