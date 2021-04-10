using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class CandidatePreference : EntityBase
    {
        public Guid? SpeciesId { get; set; }
        public double? MinWeight { get; set; }
        public double? MaxWeight { get; set; }
        public double? MinAge { get; set; }
        public double? MaxAge { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }

        public CandidateProfile CandidateProfile { get; set; }
        public Guid CandidateProfileId { get; set; }

    }
}