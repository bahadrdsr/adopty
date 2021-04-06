using System;
using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Common.Dtos
{
    public class CandidatePreferenceDto : IMapFrom<CandidatePreference>
    {
        public int? MinWeight { get; set; }
        public int? MaxWeight { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }
        public Guid CandidateProfileId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<CandidatePreference, CandidatePreferenceDto>();
        }
    }
}