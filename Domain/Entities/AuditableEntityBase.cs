using System;

namespace Domain.Entities
{
    public abstract class AuditableEntityBase : EntityBase
    {
        public AppUser CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public AppUser ModifiedBy { get; set; }
        public string ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}