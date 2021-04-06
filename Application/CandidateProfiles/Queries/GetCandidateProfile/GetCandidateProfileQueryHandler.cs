using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.CandidateProfiles.Queries.GetCandidateProfile
{
    public class GetCandidateProfileQueryHandler : IRequestHandler<GetCandidateProfileQuery, CandidateProfileDto>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetCandidateProfileQueryHandler(DataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<CandidateProfileDto> Handle(GetCandidateProfileQuery request, CancellationToken cancellationToken)
        {
            var cp = await _context.CandidateProfileDbSet.Where(x => x.AppUserId == request.AppUserId && x.IsActive == true).ProjectTo<CandidateProfileDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
            return cp;
        }
    }
}