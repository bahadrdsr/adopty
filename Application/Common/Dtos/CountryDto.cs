using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CountryDto : IMapFrom<Country>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Country, CountryDto>();
        }
    }
}