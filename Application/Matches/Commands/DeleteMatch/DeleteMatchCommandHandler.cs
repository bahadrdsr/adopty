using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Matches.Commands.DeleteMatch
{
    public class DeleteMatchCommandHandler : IRequestHandler<DeleteMatchCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public DeleteMatchCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Unit> Handle(DeleteMatchCommand request, CancellationToken cancellationToken)
        {
            var match = await _context.MatchDbSet.FindAsync(request.Id);
            if (match == null) throw new NotFoundException(nameof(Match), request.Id);

            _context.MatchDbSet.Remove(match);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}