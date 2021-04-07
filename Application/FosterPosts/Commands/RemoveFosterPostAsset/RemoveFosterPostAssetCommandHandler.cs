using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.FosterPosts.Commands.RemoveFosterPostAsset
{
    public class RemoveFosterPostAssetCommandHandler : IRequestHandler<RemoveFosterPostAssetCommand, Unit>
    {
        private readonly DataContext _context;
        public RemoveFosterPostAssetCommandHandler(DataContext context)
        {
            this._context = context;
        }
        public async Task<Unit> Handle(RemoveFosterPostAssetCommand request, CancellationToken cancellationToken)
        {
            var fpAsset = await _context.FosterPostAssetDbSet.Where(x => x.AssetId == request.AssetId && x.PostId == request.FosterPostId).FirstOrDefaultAsync();
            _context.FosterPostAssetDbSet.Remove(fpAsset);
            var asset = await _context.AssetDbSet.Where(x => x.Id == request.AssetId).FirstOrDefaultAsync();
            _context.AssetDbSet.Remove(asset);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}