using System;
using MediatR;

namespace Application.Messages.Commands.SendMessage
{
    public class SendMessageCommand : IRequest
    {
        public string Text { get; set; }
        public string RecipentId { get; set; }
        public Guid ConversationId { get; set; }
    }
}