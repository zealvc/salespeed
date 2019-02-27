using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resort.Application.User.Activity.Activity.Query;
using Resort.Domain.Entities;

namespace Resort.WebUI.Controllers.User.Activity
{
    [Route("api/[controller]")]
    public class ActivityController : Controller
    {
        private readonly ResortSiteDbContext _context;

        public ActivityController(ResortSiteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<List<ActivityModel>> GetAll()
        {
            return new ActivityQuery(_context).SelectAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ActivityModel>>> GetId([Required] long id)
        {
            var activity = _context.Activity.Where(x => x.Id == id).Select(ActivityModel.Projection).ToList();

            if (activity == null)
            {
                return NotFound();
            }

            return activity;
        }
    }
}