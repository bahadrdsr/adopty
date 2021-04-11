using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterProfiles.Commands.CreateFosterProfile
{
    public class CreateFosterProfileCommandHandler : IRequestHandler<CreateFosterProfileCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateFosterProfileCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(CreateFosterProfileCommand request, CancellationToken cancellationToken)
        {
            var fosterProfile = new FosterProfile
            {
                AppUserId = _userAccessor.UserId,
                Info = request.Info
            };

            await _context.FosterProfileDbSet.AddAsync(fosterProfile);
            await _context.SaveChangesAsync(cancellationToken);

            return fosterProfile.Id;
        }
    }
}