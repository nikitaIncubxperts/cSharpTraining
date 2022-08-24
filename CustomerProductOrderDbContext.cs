﻿using CustomerProductOrderForeignKey.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerProductOrderForeignKey {
    public class CustomerProductOrderDbContext : DbContext {
        public CustomerProductOrderDbContext() { 
        }

        CustomerProductOrderDbContext(DbContextOptions<CustomerProductOrderDbContext> options) : base(options) { 
        
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=NIKITAS\\SQLEXPRESS;Database=CustomerProductOrderDB;Trusted_Connection=True;");
            }
        }
    }
}
