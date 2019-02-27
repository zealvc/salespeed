using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class AccommodationAmenity
    {
        public long AccommodationId { get; set; }
        public long AmenityId { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual Amenity Amenity { get; set; }
    }
}
