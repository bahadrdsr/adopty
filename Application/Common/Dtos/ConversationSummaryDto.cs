using System.Collections.Generic;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class ConversationSummaryDto : IMapFrom<Conversation>
    {
        public AppUserDto FosterUser { get; set; }
        public AppUserDto CandidateUser { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Conversation, ConversationSummaryDto>()
            .ForMember(x => x.FosterUser, opt => opt.MapFrom(s => s.FosterUser))
            .ForMember(x => x.CandidateUser, opt => opt.MapFrom(s => s.CandidateUser));
        }
    }
}