using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class CandidatePreferences : EntityBase
    {
        public Guid SpeciesId { get; set; }
        public int? MinWeight { get; set; }
        public int? MaxWeight { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }

        public CandidateProfile CandidateProfile { get; set; }
        public Guid CandidateProfileId { get; set; }

    }
}