using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class HouseRuleDescription
    {
        public long HouseRuleId { get; set; }
        public string HouseRuleDescription1 { get; set; }
        public long? LanguageId { get; set; }

        public virtual HouseRule HouseRule { get; set; }
        public virtual Language Language { get; set; }
    }
}
