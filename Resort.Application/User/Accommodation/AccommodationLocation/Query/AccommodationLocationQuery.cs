using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resort.Domain.Entities;

namespace Resort.Application.User.Accommodation.AccommodationLocation.Query
{
    public class AccommodationLocationQuery
    {
        private readonly ResortSiteDbContext _context;

        public AccommodationLocationQuery(ResortSiteDbContext context)
        {
            _context = context;
        }

        public Task<List<AccommodationLocationModel>> SelectAll()
        {
            return _context.AccommodationLocation.Select(AccommodationLocationModel.Projection).ToListAsync();
        }
    }
}