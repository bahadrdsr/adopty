using MediatR;

namespace Application.Assets.Commands.DeleteAsset
{
    public class DeleteAssetCommand : IRequest
    {
        public string Id { get; set; }
    }
}