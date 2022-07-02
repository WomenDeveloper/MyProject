using System;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{   //contex : tie the database table and the classes of project
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=master; User=sa; Password=Docker@123");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}

