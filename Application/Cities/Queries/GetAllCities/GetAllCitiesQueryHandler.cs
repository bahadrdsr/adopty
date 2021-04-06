using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Cities.Queries.GetAllCities
{
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, List<CityDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllCitiesQueryHandler(DataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<List<CityDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            var cities = await _context.CityDbSet.ProjectTo<CityDto>(_mapper.ConfigurationProvider).ToListAsync();
            return cities;
        }
    }
}