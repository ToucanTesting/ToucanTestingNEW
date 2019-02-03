using System.Collections.Generic;

namespace ToucanTesting.Data.Models
{
    public class Suite : TenantEntity
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}
