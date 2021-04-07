using System;
using MediatR;

namespace Application.Conversations.Commands.CreateConversation
{
    public class CreateConversationCommand : IRequest<Guid>
    {
        public string FosterUserId { get; set; }

        public string CandidateUserId { get; set; }

    }
}