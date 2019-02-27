using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Food
    {
        public long FoodTypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }
        public long? LanguageId { get; set; }

        public virtual FoodType FoodType { get; set; }
        public virtual Language Language { get; set; }
    }
}
