using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class FoodType
    {
        public long Id { get; set; }
        public long? MenuId { get; set; }
        public string FoodType1 { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Food Food { get; set; }
    }
}
