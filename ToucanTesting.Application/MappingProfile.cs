using AutoMapper;
using ToucanTesting.Application.Suites;
using ToucanTesting.Application.Users;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<PasswordUserDto, User>()
                .ForMember(dto => dto.Password, 
                    m => m.MapFrom(u => BCrypt.Net.BCrypt.HashPassword(u.Password)));

            CreateMap<Suite, SuiteDto>();
            CreateMap<SuiteDto, Suite>();
        }
    }
}
