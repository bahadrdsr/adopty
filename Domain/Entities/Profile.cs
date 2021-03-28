using System.Collections.Generic;

namespace Domain.Entities
{
    public abstract class Profile : EntityBase //removed abstract because of exceptions on the migration
    {
        public Profile()
        {
            Photos = new List<ProfileAsset>();
        }
        public virtual ICollection<ProfileAsset> Photos { get; private set; }
 
        public string Info { get; set; }

    }
}