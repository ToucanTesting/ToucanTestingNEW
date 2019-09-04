using AutoMapper;
using ToucanTesting.Application.DTOs.Suites;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Suite, SuiteDto>();
            CreateMap<SuiteDto, Suite>();
        }
    }
}
