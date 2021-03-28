using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class FosterProfile : Profile
    {
        public FosterProfile()
        {
            Posts = new List<FosterPost>();
            LikedCandidates = new List<LikedCandidate>();
            DislikedCandidates = new List<DislikedCandidate>();
        }
        public Guid FosterPreferenceId { get; set; }
        public FosterPreference FosterPreference { get; set; }
        public ICollection<FosterPost> Posts { get; private set; }
        public ICollection<LikedCandidate> LikedCandidates { get; private set; }
        public ICollection<DislikedCandidate> DislikedCandidates { get; private set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}