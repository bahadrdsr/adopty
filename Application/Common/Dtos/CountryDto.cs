using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class CountryDto : IMapFrom<Country>
    {
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Country, CountryDto>();
        }
    }
}