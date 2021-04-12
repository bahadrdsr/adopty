using System;
using Domain.Enums;
using MediatR;

namespace Application.FosterPreferences.Commands.UpdateFosterPreference
{
    public class UpdateFosterPreferenceCommand : IRequest
    {
        public Guid Id { get; set; }
         public int MinimumAge { get; set; }
        public bool ProfileInfoExists { get; set; }
        public bool ProfilePhotoExists { get; set; }
        public bool HasExperience { get; set; }
        public Guid? FosterProfileId { get; set; }
        public bool AlreadyHasPets { get; set; }
        public FriendlyWithPeople FriendlyWithPeople { get; set; }
        public FriendlyWithPets FriendlyWithPets { get; set; }
    }
}