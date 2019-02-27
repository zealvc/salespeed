using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class ActivityLocation
    {
        public ActivityLocation()
        {
            Activity = new HashSet<Activity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Distance { get; set; }
        public string DistanceDescription { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
    }
}
