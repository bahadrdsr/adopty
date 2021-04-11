using System;
using MediatR;

namespace Application.Likes.Commands.LikeCandidate
{
    public class LikeCandidateCommand : IRequest
    {
        public Guid CandidateProfileId { get; set; }
    }
}