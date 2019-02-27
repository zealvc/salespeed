using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activity = new HashSet<Activity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
    }
}
