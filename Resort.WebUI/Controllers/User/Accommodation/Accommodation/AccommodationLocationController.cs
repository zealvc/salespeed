using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resort.Application.User.Accommodation.AccommodationLocation.Query;
using Resort.Domain.Entities;

namespace Resort.WebUI.Controllers.User.Accommodation.Accommodation
{
    [Route("api/[controller]")]
    public class AccommodationLocationController : Controller
    {
        private readonly ResortSiteDbContext _context;

        public AccommodationLocationController(ResortSiteDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public Task<List<AccommodationLocationModel>> GetAll()
        {
            return new AccommodationLocationQuery(_context).SelectAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AccommodationLocationModel>>> GetID([Required] long id)
        {
            var accommodationLocation = _context.AccommodationLocation.Where(x => x.Id == id)
                .Select(AccommodationLocationModel.Projection).ToList();

            if(accommodationLocation == null)
            {
                return NotFound();
            }
            return accommodationLocation;
        }
    }
}