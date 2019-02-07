using ToucanTesting.Application.Infrastructure.Repositories;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application.Domain.Users
{
    public interface IUsersRepository : IRepository<User, UserDto>
    {
    }
}
