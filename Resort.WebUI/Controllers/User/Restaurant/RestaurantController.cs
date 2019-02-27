using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resort.Application.User.Restaurant.Restaurant.Query;
using Resort.Domain.Entities;

namespace Resort.WebUI.Controllers.User.Restaurant
{
    [Route("api/[controller]")]
    public class RestaurantController : Controller
    {
        private readonly ResortSiteDbContext _context;

        public RestaurantController(ResortSiteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<List<RestaurantModel>> GetAll()
        {
            return new RestaurantQuery(_context).SelectAll();
        }

        [HttpGet("id")]
        public async Task<ActionResult<IEnumerable<RestaurantModel>>> GetId([Required] long id)
        {
            var restaurant = _context.Restaurant.Where(x => x.Id == id).Select(RestaurantModel.Projection).ToList();

            if (restaurant == null)
            {
                return NotFound();
            }

            return restaurant;
        }
    }
}