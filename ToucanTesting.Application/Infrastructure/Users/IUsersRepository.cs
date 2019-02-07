using ToucanTesting.Application.DTOs.Users;
using ToucanTesting.Application.Infrastructure.Repository;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application.Infrastructure.Users
{
    public interface IUsersRepository : IRepository<User, UserDto>
    {
    }
}
