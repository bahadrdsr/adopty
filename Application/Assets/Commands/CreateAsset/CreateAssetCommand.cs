using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Assets.Commands.CreateAsset
{
    public class CreateAssetCommand : IRequest<Asset>
    {
        public IFormFile File { get; set; }
        public AssetType Type { get; set; }
    }
}