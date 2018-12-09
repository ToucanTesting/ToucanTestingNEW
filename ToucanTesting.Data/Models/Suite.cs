using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Data.Models
{
    public class Suite : TenantEntity
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}
