using System;
using Application.Common.Mappings;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class AnimalSpecieDto : IMapFrom<AnimalSpecie>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<AnimalSpecie, AnimalSpecieDto>();
        }
    }
}