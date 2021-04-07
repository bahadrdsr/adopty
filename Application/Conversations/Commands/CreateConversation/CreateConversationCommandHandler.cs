using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Conversations.Commands.CreateConversation
{
    public class CreateConversationCommandHandler : IRequestHandler<CreateConversationCommand, Guid>
    {

        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateConversationCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }

        public async Task<Guid> Handle(CreateConversationCommand request, CancellationToken cancellationToken)
        {
            var convo = new Conversation
            {
                CandidateUserId = request.CandidateUserId,
                FosterUserId = request.FosterUserId
            };
            await _context.ConversationDbSet.AddAsync(convo);
            await _context.SaveChangesAsync(cancellationToken);

            return convo.Id;
        }
    }
}