using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            AccommodationRating = new HashSet<AccommodationRating>();
            AccommodationReservation = new HashSet<AccommodationReservation>();
            ActivityRating = new HashSet<ActivityRating>();
            ActivityReservation = new HashSet<ActivityReservation>();
            RestaurantRating = new HashSet<RestaurantRating>();
            RestaurantReservation = new HashSet<RestaurantReservation>();
        }

        public long Id { get; set; }
        public string ProfilePhoto { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long TypeId { get; set; }
        public long RoleId { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string About { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public string VerificationStatus { get; set; }
        public DateTime? LastSeen { get; set; }
        public string GoogleId { get; set; }
        public string FacebookId { get; set; }
        public string InstagramId { get; set; }
        public string TwitterId { get; set; }
        public string LinkedInId { get; set; }
        public string YahooId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Type Type { get; set; }
        public virtual ExtraInformation ExtraInformation { get; set; }
        public virtual LoginHistory LoginHistory { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual ICollection<AccommodationRating> AccommodationRating { get; set; }
        public virtual ICollection<AccommodationReservation> AccommodationReservation { get; set; }
        public virtual ICollection<ActivityRating> ActivityRating { get; set; }
        public virtual ICollection<ActivityReservation> ActivityReservation { get; set; }
        public virtual ICollection<RestaurantRating> RestaurantRating { get; set; }
        public virtual ICollection<RestaurantReservation> RestaurantReservation { get; set; }
    }
}
