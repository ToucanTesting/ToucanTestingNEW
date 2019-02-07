using AutoMapper;
using ToucanTesting.Application.DTOs.Users;
using ToucanTesting.Application.Infrastructure.Users;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Persistence.Repositories
{
    public class UsersRepository : BaseRepository<User, UserDto>, IUsersRepository
    {
        public UsersRepository(ToucanDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
