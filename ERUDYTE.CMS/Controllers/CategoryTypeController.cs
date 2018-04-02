using Erudyte.CMS.Data.Interfaces;
using Erudyte.CMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Erudyte.CMS.Controllers
{
    [Produces("application/json")]
    [Route("api/CategoryType")]
    public class CategoryTypeController : Controller
    {
        private readonly ICategoryTypeRepository _categoryTypeRepository;

        public CategoryTypeController(ICategoryTypeRepository categoryTypeRepository)
        {
            _categoryTypeRepository = categoryTypeRepository;
        }
        // GET: api/CategoryType
        [HttpGet]
        public IEnumerable<CategoryType> Get()
        {
            return _categoryTypeRepository.GetAll();
        }

        // GET: api/CategoryType/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategoryType
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategoryType/5
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
