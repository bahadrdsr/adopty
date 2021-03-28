using System.Collections.Generic;

namespace Domain.Entities
{
    public class Country : EntityBase
    {
        public Country()
        {
            Cities = new List<City>();
        }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public ICollection<City> Cities { get; private set; }

    }
}