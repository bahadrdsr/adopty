using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Matches.Queries.GetMatches
{
    public class GetMatchesQueryHandler : IRequestHandler<GetMatchesQuery, List<MatchDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;

        public GetMatchesQueryHandler(DataContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this._context = context;
            this._mapper = mapper;
            this._userAccessor = userAccessor;
        }
        public async System.Threading.Tasks.Task<List<MatchDto>> Handle(GetMatchesQuery request, CancellationToken cancellationToken)
        {
            var mathces = await _context.MatchDbSet
            .Where(x => x.CandidateUserId == _userAccessor.UserId || x.FosterUserId == _userAccessor.UserId)
            .ProjectTo<MatchDto>(_mapper.ConfigurationProvider).ToListAsync();

            return mathces;
        }
    }
}