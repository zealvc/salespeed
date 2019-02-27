using Resort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resort.Application
{
    public class AccommodationCreateCommand
    {
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
    }
}
