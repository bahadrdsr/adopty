using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
        }
        public FosterProfile FosterProfile { get; set; }
        public Guid? FosterProfileId { get; set; }

        public CandidateProfile CandidateProfile { get; set; }
        public Guid? CandidateProfileId { get; set; }

    }
}