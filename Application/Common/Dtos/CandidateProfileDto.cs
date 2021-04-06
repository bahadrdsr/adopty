using System.Collections.Generic;
using System.Linq;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CandidateProfileDto : IMapFrom<CandidateProfile>
    {
        public bool IsActive { get; set; }
        public CandidatePreferenceDto CandidatePreference { get; set; }
        public string AppUserId { get; set; }
        public virtual List<AssetDto> Photos { get; private set; }

        public string Info { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<CandidateProfile, CandidateProfileDto>()
            .ForMember(x => x.CandidatePreference, opt => opt.MapFrom(s => s.CandidatePreference))
            .ForMember(x => x.Photos, opt => opt.MapFrom(s => s.Photos.Select(x => x.Asset)));
        }
    }
}