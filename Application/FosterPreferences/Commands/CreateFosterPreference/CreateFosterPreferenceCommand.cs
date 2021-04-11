using System;
using Domain.Enums;
using MediatR;

namespace Application.FosterPreferences.Commands.CreateFosterPreference
{
    public class CreateFosterPreferenceCommand : IRequest<Guid>
    {
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