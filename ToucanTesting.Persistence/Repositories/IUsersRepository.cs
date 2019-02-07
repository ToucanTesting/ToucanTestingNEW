using System;
using System.Collections.Generic;
using ToucanTesting.Domain.Entities;
using ToucanTesting.Application.Dtos;

namespace ToucanTesting.Persistence.Repositories
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
