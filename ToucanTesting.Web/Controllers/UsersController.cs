using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToucanTesting.Application.Dtos;
using ToucanTesting.Persistence.Repositories;

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

        [HttpGet]
        public IActionResult Get()
        {
            var users = _repository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] PasswordUserDto userDto)
        {
            _repository.Add(userDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
