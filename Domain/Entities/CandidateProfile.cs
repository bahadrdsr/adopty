using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            LikedPosts = new List<LikedPost>();
            DislikedPosts = new List<DislikedPost>();
        }
        public bool IsActive { get; set; }
        public Guid CandidatePreferenceId { get; set; }
        public CandidatePreference CandidatePreference { get; set; }
       public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<LikedPost> LikedPosts { get; private set; }
        public ICollection<DislikedPost> DislikedPosts { get; private set; }


    }
}