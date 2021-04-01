using System;
using MediatR;

namespace Application.CandidateProfiles.Commands
{
    public class CreateCandidateProfileCommand : IRequest<Guid>
    {
        public bool IsActive { get; set; }
        public string Info { get; set; }
    }
}