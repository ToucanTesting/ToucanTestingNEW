using AutoMapper;
using ToucanTesting.Data.Models;
using ToucanTesting.Repository.Dtos;

namespace ToucanTesting.Repository
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
