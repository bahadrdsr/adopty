using System;
using System.Collections.Generic;
using Domain.Enums;

namespace Domain.Entities
{
    public class FosterPreferences : EntityBase
    {
        public FosterPreferences()
        {
            Posts = new List<FosterPost>();
        }
        public int MinimumAge { get; set; }
        public bool ProfileInfoExists { get; set; }
        public bool ProfilePhotoExists { get; set; }
        public bool HasExperience { get; set; }
        public FosterProfile FosterProfile { get; set; }
        public Guid? FosterProfileId { get; set; }
        public ICollection<FosterPost> Posts { get; private set; }


        // IF ALREADY HAS PETS
        public bool AlreadyHasPets { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }

    }
}