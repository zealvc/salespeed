using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resort.Application;
using Resort.Domain.Entities;

namespace Resort.WebUI.Controllers.User.Accommodation.Accommodation
{
    [Route("api/[controller]")]
    public class AmenityController : Controller
    {
        private readonly ResortSiteDbContext _context;

        public AmenityController(ResortSiteDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<List<AmenityModel>> GetAll()
        {
            return new AmenityQuery(_context).SelectAll();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AmenityModel>>> GetId([Required] long id)
        {
            var amenity = _context.Amenity.Where(x => x.Id == id).Select(AmenityModel.Projection).ToList();

            if(amenity == null)
            {
                return NotFound();
            }
            return amenity;
        }
    }
}