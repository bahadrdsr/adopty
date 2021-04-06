using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class MessageDto : IMapFrom<Message>
    {
        public string Text { get; set; }
        public string SenderId { get; set; }
        public string RecipentId { get; set; }
        public DateTime SentDate { get; set; }
        public Guid ConversationId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Message, MessageDto>();
        }
    }
}