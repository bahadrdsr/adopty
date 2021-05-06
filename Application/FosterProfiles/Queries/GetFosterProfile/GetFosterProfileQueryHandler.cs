using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.FosterProfiles.Queries.GetFosterProfile
{
    public class GetFosterProfileQueryHandler : IRequestHandler<GetFosterProfileQuery, FosterProfileDto>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;

        public GetFosterProfileQueryHandler(DataContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this._userAccessor = userAccessor;
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<FosterProfileDto> Handle(GetFosterProfileQuery request, CancellationToken cancellationToken)
        {
            var fp = await _context.FosterProfileDbSet.Where(x => x.AppUserId == _userAccessor.UserId).Include(x=>x.FosterPreference)
            .ProjectTo<FosterProfileDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

            return fp;
        }
    }
}