using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.CandidateProfiles.Commands
{
    public class CreateCandidateProfileCommandHandler : IRequestHandler<CreateCandidateProfileCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateCandidateProfileCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(CreateCandidateProfileCommand request, CancellationToken cancellationToken)
        {
            var cp = new CandidateProfile
            {
                AppUserId = _userAccessor.UserId,
                CandidatePreferenceId = null,
                Info = request.Info,
                IsActive = true
            };
            await _context.CandidateProfileDbSet.AddAsync(cp);
            await _context.SaveChangesAsync(cancellationToken);

            return cp.Id;
        }
    }
}