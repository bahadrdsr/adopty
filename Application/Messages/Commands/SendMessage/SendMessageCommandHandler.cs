using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Messages.Commands.SendMessage
{
    public class SendMessageCommandHandler : IRequestHandler<SendMessageCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;

        public SendMessageCommandHandler(IUserAccessor userAccessor, DataContext context)
        {
            this._userAccessor = userAccessor;
            this._context = context;
        }
        public async Task<Unit> Handle(SendMessageCommand request, CancellationToken cancellationToken)
        {
            // PUBLISH TO RABBITMQ QUEUE
            var message = new Message
            {
                ConversationId = request.ConversationId,
                RecipentId = request.RecipentId,
                SenderId = _userAccessor.UserId,
                SentDate = DateTime.UtcNow,
                Text = request.Text
            };

            await _context.MessageDbSet.AddAsync(message);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}