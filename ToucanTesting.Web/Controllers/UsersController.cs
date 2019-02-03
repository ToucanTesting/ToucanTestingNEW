using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToucanTesting.Repository.Dtos;
using ToucanTesting.Repository.Repositories;

namespace ToucanTesting.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult Get()
        {
            var users = _repository.GetAll();
            return Ok(users);
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult Post([FromBody] PasswordUserDto userDto)
        {
            _repository.Add(userDto);
            return Ok();
        }

        // PUT: api/Users/5
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
