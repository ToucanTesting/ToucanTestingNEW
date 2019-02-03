using System;
using System.Collections.Generic;
using ToucanTesting.Data.Models;
using ToucanTesting.Repository.Dtos;

namespace ToucanTesting.Repository.Repositories
{
    public interface IUsersRepository : IRepository<User, UserDto>
    {
        UserDto Get(Guid id);
        IEnumerable<UserDto> GetAll();
        void Add(UserDto dto);
        void AddRange(IEnumerable<UserDto> dtos);
        void Remove(UserDto dto);
        void RemoveRange(IEnumerable<UserDto> dtos);
    }
}
