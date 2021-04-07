using System.Collections.Generic;
using Application.Common.Dtos;
using MediatR;

namespace Application.Conversations.Queries.GetMyConversations
{
    
    public class GetMyConversationsQuery : IRequest<List<ConversationSummaryDto>>
    {
 
    }
}