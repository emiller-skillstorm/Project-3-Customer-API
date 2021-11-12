using System;
using Microsoft.EntityFrameworkCore;
using CustomerTestAPI.Domain;
namespace CustomerTestAPI.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }

        public CustomerContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Placeholder
        }
    }
}
