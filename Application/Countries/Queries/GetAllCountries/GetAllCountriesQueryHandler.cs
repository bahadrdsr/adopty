using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Countries.Queries.GetAllCountries
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, List<CountryDto>>
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetAllCountriesQueryHandler(DataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<List<CountryDto>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _context.CountryDbSet
            .ProjectTo<CountryDto>(_mapper.ConfigurationProvider).ToListAsync();

            return countries;
        }
    }
}