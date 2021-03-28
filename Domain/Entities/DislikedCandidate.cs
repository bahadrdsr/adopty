using System;

namespace Domain.Entities
{
    public class DislikedCandidate
    {
        public Guid CandidateId { get; set; }
        public CandidateProfile CandidateProfile { get; set; }

        public Guid FosterProfileId { get; set; }
        public FosterProfile FosterProfile { get; set; }
    }
}