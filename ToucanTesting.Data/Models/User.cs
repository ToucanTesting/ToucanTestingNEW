﻿namespace ToucanTesting.Data.Models
{
    public class User : TenantEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
