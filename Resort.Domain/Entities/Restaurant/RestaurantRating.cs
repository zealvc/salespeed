using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class RestaurantRating
    {
        public long RestaurantId { get; set; }
        public long? UserId { get; set; }
        public int? Star { get; set; }
        public string Comment { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }
}
