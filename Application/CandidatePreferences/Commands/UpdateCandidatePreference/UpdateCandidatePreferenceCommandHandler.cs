using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.CandidatePreferences.Commands.UpdateCandidatePreference
{
    public class UpdateCandidatePreferenceCommandHandler : IRequestHandler<UpdateCandidatePreferenceCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public UpdateCandidatePreferenceCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(UpdateCandidatePreferenceCommand request, CancellationToken cancellationToken)
        {
            var cf = await _context.CandidatePreferenceDbSet.FindAsync(request.Id);

            if (cf == null)
                throw new NotFoundException(nameof(CandidatePreference), request.Id);

            cf.CandidateProfileId = request.CandidateProfileId.Value;
            cf.FriendlyWithPeople = request.FriendlyWithPeople;
            cf.FriendlyWithPets = request.FriendlyWithPets;
            cf.MaxAge = request.MaxAge;
            cf.MinWeight = request.MinWeight;
            cf.SpeciesId = request.SpeciesId.Value;
            cf.MinAge = request.MinAge;
            cf.MaxWeight = request.MaxWeight;

            _context.CandidatePreferenceDbSet.Update(cf);
            await _context.SaveChangesAsync(cancellationToken);
            return cf.Id;
        }
    }
}