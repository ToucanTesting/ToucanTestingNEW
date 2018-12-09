using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Data.Models
{
    public class Tenant : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Suite> Suites { get; set; }
    }
}
