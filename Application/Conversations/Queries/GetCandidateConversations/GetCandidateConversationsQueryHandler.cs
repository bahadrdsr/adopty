using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Conversations.Queries.GetFosterConversations
{
    public class GetCandidateConversationsQueryHandler : IRequestHandler<GetFosterConversationsQuery, List<ConversationSummaryDto>>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetCandidateConversationsQueryHandler(DataContext context, IUserAccessor userAccessor, IMapper mapper)
        {
            this._context = context;
            this._userAccessor = userAccessor;
            this._mapper = mapper;
        }
        public async System.Threading.Tasks.Task<List<ConversationSummaryDto>> Handle(GetFosterConversationsQuery request, CancellationToken cancellationToken)
        {
            var conversations = await _context.ConversationDbSet.Where(x => x.FosterUserId == _userAccessor.UserId).Distinct()
             .ProjectTo<ConversationSummaryDto>(_mapper.ConfigurationProvider).ToListAsync();

            return conversations;
        }
    }
}