using System;
using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Dtos
{
    public class AssetDto : IMapFrom<Asset>
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }
        public void Mapping(AutoMapper.Profile profile)
        {
            profile.CreateMap<Asset, AssetDto>();
        }
    }
}