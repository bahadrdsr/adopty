using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CityDto : IMapFrom<City>
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<City, CityDto>();
        }
    }
}