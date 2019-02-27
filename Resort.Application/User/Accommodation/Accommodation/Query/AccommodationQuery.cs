using Microsoft.EntityFrameworkCore;
using Resort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resort.Application
{
    public class AccommodationQuery
    {
        private readonly ResortSiteDbContext _context;

        public AccommodationQuery(ResortSiteDbContext context)
        {
            _context = context;
        }

        public Task<List<AccommodationModel>> SelectAll()
        {
            return _context.Accommodation.Select(AccommodationModel.Projection).ToListAsync();
        }
    }
}
