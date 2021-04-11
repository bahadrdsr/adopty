using System.Collections.Generic;
using Application.Common.Dtos;
using MediatR;

namespace Application.Conversations.Queries.GetFosterConversations
{
    public class GetFosterConversationsQuery : IRequest<List<ConversationSummaryDto>>
    {

    }
}