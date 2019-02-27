using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resort.Domain.Entities;

namespace Resort.Application.User.Restaurant.Restaurant.Query
{
    public class RestaurantQuery
    {
        private readonly ResortSiteDbContext _context;

        public RestaurantQuery(ResortSiteDbContext context)
        {
            _context = context;
        }

        public Task<List<RestaurantModel>> SelectAll()
        {
            return _context.Restaurant.Select(RestaurantModel.Projection).ToListAsync();
        }
    }
}