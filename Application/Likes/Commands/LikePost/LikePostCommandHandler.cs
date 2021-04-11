using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Likes.Commands.LikePost
{
    public class LikePostCommandHandler : IRequestHandler<LikePostCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;

        public LikePostCommandHandler(IUserAccessor userAccessor, DataContext context)
        {
            this._userAccessor = userAccessor;
            this._context = context;
        }
        public async Task<Unit> Handle(LikePostCommand request, CancellationToken cancellationToken)
        {
            var candidateProfile = await _context.CandidateProfileDbSet.Where(x => x.AppUserId == _userAccessor.UserId).FirstOrDefaultAsync();
            var post = await _context.FosterPostDbSet.FindAsync(request.PostId);
            var lp = _context.LikedPostDbSet.AddAsync(new Domain.Entities.LikedPost { CandidateProfileId = candidateProfile.Id, PostId = request.PostId });
            // find if foster liked candidate
            var isLikedBack = await _context.LikedCandidateDbSet
            .Where(x => x.CandidateProfileId == candidateProfile.Id && x.FosterProfileId == post.FosterProfileId).FirstOrDefaultAsync();
            if (isLikedBack != null)
            {
                // create match
                var match = new Match
                {
                    CandidateUserId = _userAccessor.UserId,
                    FosterUserId = post.FosterProfile.AppUserId,
                    PostId = post.Id
                };
                await _context.MatchDbSet.AddAsync(match);
                var conversation = new Conversation
                {
                    CandidateUserId = _userAccessor.UserId,
                    FosterUserId = post.FosterProfile.AppUserId,
                };
                await _context.ConversationDbSet.AddAsync(conversation);
            }
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}