using System;

namespace Domain.Entities
{
    public class DislikedPost
    {
        public Guid CandidateProfileId { get; set; }
        public CandidateProfile CandidateProfile { get; set; }
        public FosterPost Post { get; set; }
        public Guid PostId { get; set; }

    }
}