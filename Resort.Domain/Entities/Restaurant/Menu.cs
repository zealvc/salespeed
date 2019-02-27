using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            FoodType = new HashSet<FoodType>();
            RestaurantMenu = new HashSet<RestaurantMenu>();
        }

        public long Id { get; set; }
        public string MenuType { get; set; }
        public string Description { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<FoodType> FoodType { get; set; }
        public virtual ICollection<RestaurantMenu> RestaurantMenu { get; set; }
    }
}
