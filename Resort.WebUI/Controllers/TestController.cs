using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resort.Domain.Entities;
using System.Diagnostics;

namespace Resort.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/test
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromQuery(Name = "ids1")]int[] ids)
        {
            Debug.WriteLine(ids.Count());
            //ResortSiteDbContext context = new ResortSiteDbContext();
            //Amenity amenity = context.Amenity.Single(i => i.Id == 5);
            //Debug.WriteLine(amenity.Description);
            //            Amenity adr = new Amenity() { Name = "Mom", Description = "1st insert.", Image = "Test img", LanguageId =1 };
            //            context.Amenity.Add(adr);
            //            await context.SaveChangesAsync();
            Debug.WriteLine("Finish!!!!");
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
