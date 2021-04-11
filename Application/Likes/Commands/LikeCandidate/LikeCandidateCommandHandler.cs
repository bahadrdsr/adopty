using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Likes.Commands.LikeCandidate
{
    public class LikeCandidateCommandHandler : IRequestHandler<LikeCandidateCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;

        public LikeCandidateCommandHandler(IUserAccessor userAccessor, DataContext context)
        {
            this._userAccessor = userAccessor;
            this._context = context;
        }
        public async Task<Unit> Handle(LikeCandidateCommand request, CancellationToken cancellationToken)
        {
            var fosterProfile = await _context.FosterProfileDbSet.Where(x => x.AppUserId == _userAccessor.UserId).FirstOrDefaultAsync();
            var cp = await _context.CandidateProfileDbSet.FindAsync(request.CandidateProfileId);
            var postIds = fosterProfile.Posts.Select(x => x.Id).ToList();
            await _context.LikedCandidateDbSet.AddAsync(new Domain.Entities.LikedCandidate { CandidateProfileId = cp.Id, FosterProfileId = fosterProfile.Id });

            var previouslyLikedPost = await _context.LikedPostDbSet
           .Where(x => postIds.Contains(x.PostId) && x.CandidateProfileId == cp.Id).FirstOrDefaultAsync();
            if (previouslyLikedPost != null)
            {
                // create match
                var match = new Match
                {
                    CandidateUserId = cp.AppUserId,
                    FosterUserId = _userAccessor.UserId,
                    PostId = previouslyLikedPost.PostId
                };
                await _context.MatchDbSet.AddAsync(match);
                var conversation = new Conversation
                {
                    CandidateUserId = cp.AppUserId,
                    FosterUserId = _userAccessor.UserId,
                };
                await _context.ConversationDbSet.AddAsync(conversation);
            }
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}