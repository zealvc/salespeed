using System;
using System.Linq.Expressions;

namespace Resort.Application.User.Accommodation.AccommodationLocation.Query
{
    public class AccommodationLocationModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Distance { get; set; }
        public string DistanceDescription { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public long? LanguageId { get; set; }

        public static Expression<Func<Domain.Entities.AccommodationLocation, AccommodationLocationModel>> Projection
        {
            get
            {
                return x=> new AccommodationLocationModel
                {
                    Id=x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Description = x.Description,
                    Distance = x.Distance,
                    DistanceDescription = x.DistanceDescription,
                    Longitude = x.Longitude,
                    LanguageId = x.LanguageId,
                    Latitude = x.Latitude
                };
            }
        }
    }
}