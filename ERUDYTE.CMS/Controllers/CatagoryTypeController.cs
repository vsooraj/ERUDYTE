using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Erudyte.CMS.Controllers
{
    [Produces("application/json")]
    [Route("api/CatagoryType")]
    public class CatagoryTypeController : Controller
    {
        // GET: api/CatagoryType
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CatagoryType/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CatagoryType
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CatagoryType/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
