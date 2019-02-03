using System;
using System.Collections.Generic;
using System.Text;
using ToucanTesting.Data.Models;
using ToucanTesting.Repository.Dtos;

namespace ToucanTesting.Repository.Repositories
{
    public interface ISuiteRepository : IRepository<Suite, SuiteDto>
    {
    }
}
