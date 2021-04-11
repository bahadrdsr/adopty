using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class MatchDto : IMapFrom<Match>
    {
        public AppUserDto FosterUser { get; set; }
        public AppUserDto CandidateUser { get; set; }
        public Guid PostId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Match, MatchDto>()
             .ForMember(x => x.CandidateUser, opt => opt.MapFrom(s => s.CandidateUser))
             .ForMember(x => x.FosterUser, opt => opt.MapFrom(s => s.FosterUser));
        }
    }
}