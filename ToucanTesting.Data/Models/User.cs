using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Data.Models
{
    public class User : TenantEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
