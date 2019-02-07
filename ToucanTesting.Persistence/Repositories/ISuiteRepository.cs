using ToucanTesting.Domain.Entities;
using ToucanTesting.Application.Dtos;

namespace ToucanTesting.Persistence.Repositories
{
    public interface ISuiteRepository : IRepository<Suite, SuiteDto>
    {
    }
}
