using System.Collections.Generic;

namespace ToucanTesting.Domain.Entities
{
    public class Tenant : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Suite> Suites { get; set; }
    }
}
