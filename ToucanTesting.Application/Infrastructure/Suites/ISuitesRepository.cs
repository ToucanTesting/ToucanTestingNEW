using ToucanTesting.Application.DTOs.Suites;
using ToucanTesting.Application.Infrastructure.Repository;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application.Infrastructure.Suites
{
    public interface ISuitesRepository : IRepository<Suite, SuiteDto>
    {
    }
}
