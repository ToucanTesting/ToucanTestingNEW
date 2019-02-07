using ToucanTesting.Application.Infrastructure.Repositories;
using ToucanTesting.Domain.Entities;

namespace ToucanTesting.Application.Domain.Suites
{
    public interface ISuitesRepository : IRepository<Suite, SuiteDto>
    {
    }
}
