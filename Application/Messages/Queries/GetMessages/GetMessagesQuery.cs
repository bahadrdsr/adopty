using System;
using Application.Common.ViewModels;
using MediatR;

namespace Application.Messages.Queries.GetMessages
{
    public class GetMessagesQuery : IRequest<MessagesVm>
    {
        public Guid ConversationId { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }

    }
}