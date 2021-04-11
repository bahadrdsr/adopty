using System;
using Application.Common.Dtos;
using MediatR;

namespace Application.Conversations.Queries.GetConversationById
{
    public class GetConversationByIdQuery : IRequest<ConversationDto>
    {
        public Guid Id { get; set; }
    }
}