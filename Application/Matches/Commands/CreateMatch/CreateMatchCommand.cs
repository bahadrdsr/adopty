using System;
using MediatR;

namespace Application.Matches.Commands.CreateMatch
{
    public class CreateMatchCommand : IRequest<Guid>
    {
        public string FosterUserId { get; set; }
        public string CandidateUserId { get; set; }
        public Guid PostId { get; set; }
    }
}