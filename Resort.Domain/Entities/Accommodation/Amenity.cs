using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Amenity
    {
        public Amenity()
        {
            AccommodationAmenity = new HashSet<AccommodationAmenity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<AccommodationAmenity> AccommodationAmenity { get; set; }
    }
}
