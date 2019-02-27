using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resort.Domain.Entities;

namespace Resort.Application
{
    public class AmenityQuery
    {
        private readonly ResortSiteDbContext _context;

        public AmenityQuery(ResortSiteDbContext context)
        {
            _context = context;
        }

        public Task<List<AmenityModel>> SelectAll()
        {
            return _context.Amenity.Select(AmenityModel.Projection).ToListAsync();
        }
    }
}