using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Matches.Commands.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateMatchCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = new Match
            {
                CandidateUserId = request.CandidateUserId,
                FosterUserId = request.FosterUserId,
                PostId = request.PostId
            };

            await _context.MatchDbSet.AddAsync(match);
            await _context.SaveChangesAsync(cancellationToken);

            return match.Id;
        }
    }
}