using System;

namespace Domain.Entities
{
    public class Match : EntityBase
    {
        public AppUser FosterUser { get; set; }
        public string FosterUserId { get; set; }

        public AppUser CandidateUser { get; set; }
        public string CandidateUserId { get; set; }
      
        public FosterPost Post { get; set; }
        public Guid PostId { get; set; }

    }
}