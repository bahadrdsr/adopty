using System;
using System.Threading;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Assets.Commands.CreateAsset
{
    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Asset>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoAccessor _photoAccessor;
        public CreateAssetCommandHandler(DataContext context, IUserAccessor userAccessor, IPhotoAccessor photoAccessor)
        {
            this._photoAccessor = photoAccessor;
            this._userAccessor = userAccessor;
            this._context = context;
        }

        public async System.Threading.Tasks.Task<Asset> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var photoUploadResult = _photoAccessor.AddPhoto(request.File);

                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == _userAccessor.UserId);

                var asset = new Asset
                {
                    Url = photoUploadResult.Url,
                    PublicId = photoUploadResult.PublicId,
                    Type = request.Type,
                };

                await _context.AssetDbSet.AddAsync(asset);
                var success = await _context.SaveChangesAsync() > 0;
                if (success) return asset;
                throw new Exception("Upload Asset Error");
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}