using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Marlowe.Antonius.Controllers
{
    [Route("api/[controller]")]
    public class CvController : Controller
    {
        // GET api/cv
        [HttpGet]
        public IActionResult Get()
        {
            var service = new CvService();
            var model = new Cv
            {
                PersoonlijkeGegevens = service.PersoonlijkeGegevens(),
                Werkervaring = service.GetWerkervaring(),
                Opleidingen = service.GetOpleidingen()

            };
            
            return Ok(model);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
