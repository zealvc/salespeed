using Resort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resort.Application
{
    public class AccommodationCreateCommandHandler
    {
        private readonly ResortSiteDbContext _context;

        public AccommodationCreateCommandHandler(ResortSiteDbContext context)
        {
            _context = context;
        }

        public void Create(AccommodationCreateCommand request)
        {
            var accommodation = new Accommodation
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                AccommodationTypeId = request.AccommodationTypeId,
                Description = request.Description,
                GuestCount = request.GuestCount,
                BedRoomCount = request.BedRoomCount,
                BedCount = request.BedCount,
                BathCount = request.BathCount,
                LocationId = request.LocationId,
                PricePerNight = request.PricePerNight,
                CoverImage = request.CoverImage,
                MainImage = request.MainImage,
                CancellationPolicy = request.CancellationPolicy,
                DateAdded = request.DateAdded,
                LanguageId = request.LanguageId
            };
            _context.Add(accommodation);
            _context.SaveChanges();
        }
    }
}
