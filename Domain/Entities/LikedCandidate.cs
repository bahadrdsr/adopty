using System;

namespace Domain.Entities
{
    public class LikedCandidate
    {
        public Guid CandidateProfileId { get; set; }
        public CandidateProfile CandidateProfile { get; set; }

        public Guid FosterProfileId { get; set; }
        public FosterProfile FosterProfile { get; set; }

    }
}