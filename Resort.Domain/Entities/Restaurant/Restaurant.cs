using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            RestaurantReservation = new HashSet<RestaurantReservation>();
        }

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long RestaurantTypeId { get; set; }
        public string ReservationStatus { get; set; }
        public decimal? PriceRange { get; set; }
        public string Price { get; set; }
        public string CreditCard { get; set; }
        public string Wifi { get; set; }
        public string Drink { get; set; }
        public string MealService { get; set; }
        public string DiningOption { get; set; }
        public string Restroom { get; set; }
        public string Parking { get; set; }
        public long? LocationId { get; set; }
        public long? LanguageId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }
        public virtual RestaurantLocation Location { get; set; }
        public virtual RestaurantType RestaurantType { get; set; }
        public virtual RestaurantMenu RestaurantMenu { get; set; }
        public virtual RestaurantRating RestaurantRating { get; set; }
        public virtual ICollection<RestaurantReservation> RestaurantReservation { get; set; }
    }
}
