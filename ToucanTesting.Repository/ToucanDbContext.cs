﻿using Microsoft.EntityFrameworkCore;
using ToucanTesting.Data.Models;

namespace ToucanTesting.Repository
{
    public class ToucanDbContext : DbContext
    {
        public ToucanDbContext(DbContextOptions<ToucanDbContext> options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Suite> Suites { get; set; }
        public DbSet<Module> Modules { get; set; }
    }
}
