using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class ActivityRating
    {
        public long ActivityId { get; set; }
        public long? UserId { get; set; }
        public int? Star { get; set; }
        public string Comment { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual User User { get; set; }
    }
}
