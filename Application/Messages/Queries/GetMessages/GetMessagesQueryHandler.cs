using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Common.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Messages.Queries.GetMessages
{
    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, MessagesVm>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;

        public GetMessagesQueryHandler(DataContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this._context = context;
            this._mapper = mapper;
            this._userAccessor = userAccessor;
        }
        public async Task<MessagesVm> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var messages = await _context.MessageDbSet
           .Where(x => x.ConversationId == request.ConversationId).Skip((request.PageNo - 1) * request.PageSize).Take(request.PageSize)
           .ProjectTo<MessageDto>(_mapper.ConfigurationProvider).ToListAsync();

            var vm = new MessagesVm
            {
                Messages = messages,
                PageNo = request.PageNo,
                PageSize = request.PageSize
            };

            return vm;
        }
    }
}