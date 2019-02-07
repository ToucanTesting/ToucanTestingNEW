using AutoMapper;
using ToucanTesting.Domain.Entities;
using ToucanTesting.Application.Dtos;

namespace ToucanTesting.Persistence.Repositories
{
    public class UsersRespository : BaseRepository<User, UserDto>, IUsersRepository
    {
        public UsersRespository(ToucanDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
