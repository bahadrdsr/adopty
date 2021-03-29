using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.CandidatePreferences.Commands.CreateCandidatePreference
{
    public class CreateCandidatePreferenceCommandHandler : IRequestHandler<CreateCandidatePreferenceCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateCandidatePreferenceCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }

        public async Task<Guid> Handle(CreateCandidatePreferenceCommand request, CancellationToken cancellationToken)
        {
            var cp = new CandidatePreference
            {
                CandidateProfileId = request.CandidateProfileId.Value,
                FriendlyWithPeople = request.FriendlyWithPeople,
                FriendlyWithPets = request.FriendlyWithPets,
                MaxAge = request.MaxAge,
                MaxWeight = request.MaxWeight,
                MinAge = request.MinAge,
                MinWeight = request.MinWeight,
                SpeciesId = request.SpeciesId.Value
            };
            await _context.CandidatePreferenceDbSet.AddAsync(cp);
            await _context.SaveChangesAsync(cancellationToken);
            return cp.Id;
        }
    }
}