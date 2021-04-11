using System;
using System.Collections.Generic;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class ConversationDto : IMapFrom<Conversation>
    {
        public Guid Id { get; set; }
        public AppUserDto FosterUser { get; set; }
        public AppUserDto CandidateUser { get; set; }
        public List<MessageDto> Messages { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Conversation, ConversationDto>()
            .ForMember(x => x.FosterUser, opt => opt.MapFrom(s => s.FosterUser))
            .ForMember(x => x.Messages, opt => opt.MapFrom(s => s.Messages))
            .ForMember(x => x.CandidateUser, opt => opt.MapFrom(s => s.CandidateUser));
        }
    }
}