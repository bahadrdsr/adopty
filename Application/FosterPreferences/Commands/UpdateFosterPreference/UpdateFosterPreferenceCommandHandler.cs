using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterPreferences.Commands.UpdateFosterPreference
{
    public class UpdateFosterPreferenceCommandHandler : IRequestHandler<UpdateFosterPreferenceCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public UpdateFosterPreferenceCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Unit> Handle(UpdateFosterPreferenceCommand request, CancellationToken cancellationToken)
        {
            var fp = await _context.FosterPreferenceDbSet.FindAsync(request.Id);
            if (fp == null) throw new NotFoundException(nameof(FosterPreference), request.Id);
            fp.FosterProfileId = request.FosterProfileId;
            fp.FriendlyWithPeople = request.FriendlyWithPeople;
            fp.FriendlyWithPets = request.FriendlyWithPets;
            fp.HasExperience = request.HasExperience;
            fp.MinimumAge = request.MinimumAge;
            fp.ProfileInfoExists = request.ProfileInfoExists;
            fp.ProfilePhotoExists = request.ProfilePhotoExists;

            _context.FosterPreferenceDbSet.Update(fp);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}