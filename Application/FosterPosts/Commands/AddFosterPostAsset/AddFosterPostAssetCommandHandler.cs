using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterPosts.Commands.AddFosterPostAsset
{
    public class AddFosterPostAssetCommandHandler : IRequestHandler<AddFosterPostAssetCommand, Unit>
    {
        private readonly DataContext _context;
        public AddFosterPostAssetCommandHandler(DataContext context)
        {
            this._context = context;
        }
        public async Task<Unit> Handle(AddFosterPostAssetCommand request, CancellationToken cancellationToken)
        {
            var fpa = new FosterPostAsset
            {
                AssetId = request.AssetId,
                PostId = request.FosterPostId
            };
            await _context.FosterPostAssetDbSet.AddAsync(fpa);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}