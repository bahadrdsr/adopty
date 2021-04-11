using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Conversations.Queries.GetConversationById
{
    public class GetConversationByIdQueryHandler : IRequestHandler<GetConversationByIdQuery, ConversationDto>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetConversationByIdQueryHandler(DataContext context, IUserAccessor userAccessor, IMapper mapper)
        {
            this._context = context;
            this._userAccessor = userAccessor;
            this._mapper = mapper;
        }

        public async Task<ConversationDto> Handle(GetConversationByIdQuery request, CancellationToken cancellationToken)
        {
            var conversation = await _context.ConversationDbSet
            .ProjectTo<ConversationDto>(_mapper.ConfigurationProvider).Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            return conversation;
        }
    }
}