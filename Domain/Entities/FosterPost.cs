using System;
using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities
{
    public class FosterPost : AuditableEntityBase
    {
        public FosterPost()
        {
            Assets = new List<FosterPostAsset>();
        }
        public string Name { get; set; }
        public string Text { get; set; }
        public AnimalSpecie Specie { get; set; }
        public Guid SpeciesId { get; set; }
        public Guid FosterProfileId { get; set; }
        public FosterProfile FosterProfile { get; set; }
        public Gender Gender { get; set; }
        public FosterPostStatus Status { get; set; }

        public virtual ICollection<FosterPostAsset> Assets { get; private set; }

    }
}