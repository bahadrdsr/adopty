using System;

namespace Domain.Entities
{
    public class Message : EntityBase
    {
        public string Text { get; set; }
        public AppUser Sender { get; set; }
        public string SenderId { get; set; }
        public AppUser Recipent { get; set; }
        public string RecipentId { get; set; }
        public DateTime SentDate { get; set; }

        public Conversation Conversation { get; set; }
        public Guid ConversationId { get; set; }

    }
}