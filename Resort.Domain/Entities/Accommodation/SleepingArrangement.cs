using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class SleepingArrangement
    {
        public long AccommodationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? LanguageId { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual Language Language { get; set; }
    }
}
