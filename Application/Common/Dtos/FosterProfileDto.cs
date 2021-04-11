using System;
using System.Collections.Generic;
using System.Linq;
using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Common.Dtos
{
    public class FosterProfileDto : IMapFrom<FosterProfile>
    {
        public Guid Id { get; set; }
        public FosterPreferenceDto FosterPreference { get; set; }
        public string AppUserId { get; set; }
        public List<AssetDto> Photos { get; private set; }
        public string Info { get; set; }

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<FosterProfile, FosterProfileDto>()
              .ForMember(x => x.FosterPreference, opt => opt.MapFrom(s => s.FosterPreference))
              .ForMember(x => x.Photos, opt => opt.MapFrom(s => s.Photos.Select(x => x.Asset)));
        }
    }
}