using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Assets.Commands.DeleteAsset
{
    public class DeleteAssetCommandHandler : IRequestHandler<DeleteAssetCommand, Unit>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoAccessor _photoAccessor;
        public DeleteAssetCommandHandler(DataContext context, IUserAccessor userAccessor, IPhotoAccessor photoAccessor)
        {
            _photoAccessor = photoAccessor;
            _userAccessor = userAccessor;
            _context = context;
        }

        public async Task<Unit> Handle(DeleteAssetCommand request, CancellationToken cancellationToken)
        {
            var asset = await _context.AssetDbSet.FindAsync(request.Id);
            if (asset == null) throw new NotFoundException(nameof(Asset), request.Id);
            var result = _photoAccessor.DeletePhoto(asset.Id.ToString());
            if (result == null) throw new Exception("Problem deleting asset from cloud");
            _context.AssetDbSet.Remove(asset);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}