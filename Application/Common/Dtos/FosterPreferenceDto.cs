using System;
using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Common.Dtos
{
    public class FosterPreferenceDto : IMapFrom<FosterPreference>
    {
        public Guid Id { get; set; }
        public int MinimumAge { get; set; }
        public bool ProfileInfoExists { get; set; }
        public bool ProfilePhotoExists { get; set; }
        public bool HasExperience { get; set; }
        public Guid? FosterProfileId { get; set; }
        public bool AlreadyHasPets { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<FosterPreference, FosterPreferenceDto>();
        }
    }
}