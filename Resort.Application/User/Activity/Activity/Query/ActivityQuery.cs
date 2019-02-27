using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resort.Domain.Entities;

namespace Resort.Application.User.Activity.Activity.Query
{
    public class ActivityQuery
    {
        private readonly ResortSiteDbContext _context;

        public ActivityQuery(ResortSiteDbContext context)
        {
            _context = context;
        }

        public Task<List<ActivityModel>> SelectAll()
        {
            return _context.Activity.Select(ActivityModel.Projection).ToListAsync();
        }
    }
}