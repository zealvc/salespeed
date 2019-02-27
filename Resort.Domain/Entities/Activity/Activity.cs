using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityReservation = new HashSet<ActivityReservation>();
        }

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long ActivityTypeId { get; set; }
        public DateTime? Duration { get; set; }
        public string PricePerPerson { get; set; }
        public string LanguageAvailable { get; set; }
        public string Include { get; set; }
        public long? LocationId { get; set; }
        public string ToDo { get; set; }
        public string Provide { get; set; }
        public string ToBring { get; set; }
        public string OtherDescription { get; set; }
        public int? GroupSize { get; set; }
        public string WhoCanCome { get; set; }
        public string CancellationPolicy { get; set; }
        public long? LanguageId { get; set; }

        public virtual ActivityType ActivityType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }
        public virtual ActivityLocation Location { get; set; }
        public virtual ActivityRating ActivityRating { get; set; }
        public virtual ICollection<ActivityReservation> ActivityReservation { get; set; }
    }
}
