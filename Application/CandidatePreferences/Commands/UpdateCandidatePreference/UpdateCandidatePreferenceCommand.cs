using System;
using Domain.Enums;
using MediatR;

namespace Application.CandidatePreferences.Commands.UpdateCandidatePreference
{
    public class UpdateCandidatePreferenceCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }

        public Guid? SpeciesId { get; set; }
        public int? MinWeight { get; set; }
        public int? MaxWeight { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }
        public Guid? CandidateProfileId { get; set; }
    }
}