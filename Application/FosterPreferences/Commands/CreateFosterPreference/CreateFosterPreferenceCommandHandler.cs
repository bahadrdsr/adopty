using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterPreferences.Commands.CreateFosterPreference
{
    public class CreateFosterPreferenceCommandHandler : IRequestHandler<CreateFosterPreferenceCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateFosterPreferenceCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(CreateFosterPreferenceCommand request, CancellationToken cancellationToken)
        {
            var fosterPref = new FosterPreference
            {
                AlreadyHasPets = request.AlreadyHasPets,
                FosterProfileId = request.FosterProfileId,
                FriendlyWithPeople = request.FriendlyWithPeople,
                FriendlyWithPets = request.FriendlyWithPets,
                HasExperience = request.HasExperience,
                MinimumAge = request.MinimumAge,
                ProfileInfoExists = request.ProfileInfoExists,
                ProfilePhotoExists = request.ProfilePhotoExists
            };

            await _context.FosterPreferenceDbSet.AddAsync(fosterPref);
            await _context.SaveChangesAsync(cancellationToken);

            return fosterPref.Id;
        }
    }
}