using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resort.Application;
using Resort.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resort.WebUI.Controllers.User.Accommodation.Accommodation
{
    [Route("api/[controller]")]
    public class AccommodationController : Controller
    {
        private readonly ResortSiteDbContext _context;

        public AccommodationController(ResortSiteDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public Task<List<AccommodationModel>> GetAll()
        {
            return new AccommodationQuery(_context).SelectAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AccommodationModel>>> GetId([Required] long id)
        {
            var accommodation = _context.Accommodation.Where(x => x.Id == id).Select(AccommodationModel.Projection).ToList();

            if(accommodation == null)
            {
                return NotFound();
            }
            return accommodation;
            //Not Yet Done
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromForm]AccommodationCreateCommand request)
        {
            new AccommodationCreateCommandHandler(_context).Create(request);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
