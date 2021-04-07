using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.FosterPosts.Commands.UpdateFosterPost
{
    public class UpdateFosterPostCommandHandler : IRequestHandler<UpdateFosterPostCommand, Unit>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public UpdateFosterPostCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Unit> Handle(UpdateFosterPostCommand request, CancellationToken cancellationToken)
        {
            var fp = await _context.FosterPostDbSet.FindAsync(request.Id);
            if (fp == null) throw new NotFoundException(nameof(FosterPost), request.Id);
            fp.FosterProfileId = request.FosterProfileId;
            fp.Gender = request.Gender;
            fp.ModifiedById = _userAccessor.UserId;
            fp.ModifiedDate = DateTime.UtcNow;
            fp.Name = request.Name;
            fp.SpeciesId = request.SpeciesId;
            fp.Status = request.Status;
            fp.Text = request.Text;

            _context.FosterPostDbSet.Update(fp);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}