using System.Collections.Generic;
using Application.Common.Dtos;
using MediatR;

namespace Application.Cities.Queries.GetAllCities
{
    public class GetAllCitiesQuery : IRequest<List<CityDto>>
    {
        
    }
}