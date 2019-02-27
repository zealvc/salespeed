using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class AccommodationType
    {
        public AccommodationType()
        {
            Accommodation = new HashSet<Accommodation>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Accommodation> Accommodation { get; set; }
    }
}
