using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using MediatR;
using Domain.Entities;
using Persistence;

namespace Application.FosterPosts.Commands.CreateFosterPost
{
    public class CreateFosterPostCommandHandler : IRequestHandler<CreateFosterPostCommand, Guid>
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;
        public CreateFosterPostCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            this._context = context;
            this._userAccessor = userAccessor;
        }
        public async Task<Guid> Handle(CreateFosterPostCommand request, CancellationToken cancellationToken)
        {
            var fp = new FosterPost
            {
                CreatedById = _userAccessor.UserId,
                CreatedDate = DateTime.UtcNow,
                Name = request.Name,
                SpeciesId = request.SpeciesId,
                FosterProfileId = request.FosterProfileId,
                Gender = request.Gender,
                Status = request.Status,
                Text = request.Text
            };
            await _context.AddAsync(fp);
            await _context.SaveChangesAsync(cancellationToken);

            return fp.Id;
        }
    }
}