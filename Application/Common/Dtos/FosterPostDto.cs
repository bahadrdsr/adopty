using System;
using System.Collections.Generic;
using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Common.Dtos
{
    public class FosterPostDto : IMapFrom<FosterPost>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public AnimalSpecie Specie { get; set; }
        public Guid SpeciesId { get; set; }
        public Guid FosterProfileId { get; set; }
        public FosterProfile FosterProfile { get; set; }
        public Gender Gender { get; set; }
        public FosterPostStatus Status { get; set; }
        public List<AssetDto> Assets { get; private set; }
        public string CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}