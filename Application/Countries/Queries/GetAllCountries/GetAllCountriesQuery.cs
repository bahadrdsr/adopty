using System.Collections.Generic;
using Application.Common.Dtos;
using MediatR;

namespace Application.Countries.Queries.GetAllCountries
{
    public class GetAllCountriesQuery : IRequest<List<CountryDto>>
    {

    }
}