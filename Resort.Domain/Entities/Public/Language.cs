using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Language
    {
        public Language()
        {
            Accommodation = new HashSet<Accommodation>();
            AccommodationLocation = new HashSet<AccommodationLocation>();
            AccommodationReservation = new HashSet<AccommodationReservation>();
            AccommodationType = new HashSet<AccommodationType>();
            Activity = new HashSet<Activity>();
            ActivityLocation = new HashSet<ActivityLocation>();
            ActivityReservation = new HashSet<ActivityReservation>();
            ActivityType = new HashSet<ActivityType>();
            Amenity = new HashSet<Amenity>();
            Category = new HashSet<Category>();
            Food = new HashSet<Food>();
            FoodType = new HashSet<FoodType>();
            HouseRule = new HashSet<HouseRule>();
            HouseRuleDescription = new HashSet<HouseRuleDescription>();
            Menu = new HashSet<Menu>();
            Restaurant = new HashSet<Restaurant>();
            RestaurantReservation = new HashSet<RestaurantReservation>();
            RestaurantType = new HashSet<RestaurantType>();
            SleepingArrangement = new HashSet<SleepingArrangement>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Accommodation> Accommodation { get; set; }
        public virtual ICollection<AccommodationLocation> AccommodationLocation { get; set; }
        public virtual ICollection<AccommodationReservation> AccommodationReservation { get; set; }
        public virtual ICollection<AccommodationType> AccommodationType { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<ActivityLocation> ActivityLocation { get; set; }
        public virtual ICollection<ActivityReservation> ActivityReservation { get; set; }
        public virtual ICollection<ActivityType> ActivityType { get; set; }
        public virtual ICollection<Amenity> Amenity { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Food> Food { get; set; }
        public virtual ICollection<FoodType> FoodType { get; set; }
        public virtual ICollection<HouseRule> HouseRule { get; set; }
        public virtual ICollection<HouseRuleDescription> HouseRuleDescription { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
        public virtual ICollection<RestaurantReservation> RestaurantReservation { get; set; }
        public virtual ICollection<RestaurantType> RestaurantType { get; set; }
        public virtual ICollection<SleepingArrangement> SleepingArrangement { get; set; }
    }
}
