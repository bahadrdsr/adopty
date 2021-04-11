using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterProfiles.Commands.UpdateFosterProfile
{
    public class UpdateFosterProfileCommandHandler : IRequestHandler<UpdateFosterProfileCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public UpdateFosterProfileCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Unit> Handle(UpdateFosterProfileCommand request, CancellationToken cancellationToken)
        {
            var fp = await _context.FosterProfileDbSet.FindAsync(request.Id);
            if (fp == null) throw new NotFoundException(nameof(FosterProfile), request.Id);
            fp.Info = request.Info;

            _context.FosterProfileDbSet.Update(fp);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}