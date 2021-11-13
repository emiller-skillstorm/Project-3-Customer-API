using CustomerTestAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CustomerTestAPI.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Placeholder
            modelBuilder.Entity<Customer>()
                .HasOne(a => a.Address);
            
        }
    }
}
