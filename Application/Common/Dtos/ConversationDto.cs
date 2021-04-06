using System.Collections.Generic;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class ConversationDto : IMapFrom<Conversation>
    {
        public string FosterUserId { get; set; }
        public List<MessageDto> Messages { get; private set; }
        public string CandidateUserId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Conversation, ConversationDto>()
            .ForMember(x => x.Messages, opt => opt.MapFrom(s => s.Messages));
        }
    }
} 