using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class HouseRule
    {
        public HouseRule()
        {
            AccommodationHouseRule = new HashSet<AccommodationHouseRule>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? LanguageId { get; set; } 

        public virtual Language Language { get; set; }
        public virtual HouseRuleDescription HouseRuleDescription { get; set; }
        public virtual ICollection<AccommodationHouseRule> AccommodationHouseRule { get; set; }
    }
}
