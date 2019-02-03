using ToucanTesting.Data.Models;
using ToucanTesting.Repository.Dtos;
using AutoMapper;

namespace ToucanTesting.Repository.Repositories
{
    public class UsersRespository : BaseRepository<User, UserDto>, IUsersRepository
    {
        public UsersRespository(ToucanDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
