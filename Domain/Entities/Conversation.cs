using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Conversation : EntityBase
    {
        public Conversation()
        {
            Messages = new List<Message>();
        }
        public AppUser FosterUser { get; set; }
        public string FosterUserId { get; set; }

        public AppUser CandidateUser { get; set; }
        public string CandidateUserId { get; set; }

        public virtual ICollection<Message> Messages { get; private set; }

    }
}