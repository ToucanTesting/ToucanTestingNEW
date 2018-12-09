using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToucanTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuitesController : ControllerBase
    {
        // GET: api/Suites
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new
            {
                Result = new string[] {"one", "two"}
            });
        }

        // GET: api/Suites/5
//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }

        // POST: api/Suites
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }
//
//        // PUT: api/Suites/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }
//
//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
    }
}
