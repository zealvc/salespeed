using System;
using System.Linq.Expressions;
using Resort.Domain.Entities;

namespace Resort.Application
{
    public class AmenityModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public static Expression<Func<Amenity, AmenityModel>> Projection
        {
            get
            {
                return x => new AmenityModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Image = x.Image,
                };
            }
        }
    }
}