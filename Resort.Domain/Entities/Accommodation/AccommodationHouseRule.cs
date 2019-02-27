using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class AccommodationHouseRule
    {
        public long AccommodationId { get; set; }
        public long? HouseRuleId { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual HouseRule HouseRule { get; set; }
    }
}
