using System;
using Domain.Enums;
using MediatR;

namespace Application.CandidatePreferences.Commands.CreateCandidatePreference
{
    public class CreateCandidatePreferenceCommand : IRequest<Guid>
    {
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