using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Accommodation
    {
        public Accommodation()
        {
            AccommodationReservation = new HashSet<AccommodationReservation>();
        }

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public long AccommodationTypeId { get; set; }
        public string Description { get; set; }
        public int? GuestCount { get; set; }
        public int? BedRoomCount { get; set; }
        public int? BedCount { get; set; }
        public int? BathCount { get; set; }
        public long? LocationId { get; set; }
        public decimal? PricePerNight { get; set; }
        public string CoverImage { get; set; }
        public string MainImage { get; set; }
        public string CancellationPolicy { get; set; }
        public DateTime? DateAdded { get; set; }
        public long? LanguageId { get; set; }

        public virtual AccommodationType AccommodationType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Language Language { get; set; }
        public virtual AccommodationLocation Location { get; set; }
        public virtual AccommodationAmenity AccommodationAmenity { get; set; }
        public virtual AccommodationHouseRule AccommodationHouseRule { get; set; }
        public virtual AccommodationImage AccommodationImage { get; set; }
        public virtual AccommodationRating AccommodationRating { get; set; }
        public virtual SleepingArrangement SleepingArrangement { get; set; }
        public virtual ICollection<AccommodationReservation> AccommodationReservation { get; set; }
    }
}
