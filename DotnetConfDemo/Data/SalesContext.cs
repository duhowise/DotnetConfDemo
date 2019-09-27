using DotnetConfDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetConfDemo.Data
{

    public class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //this is just for demo purposes, never hardCode your connectionString
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=true;");
        }
    }
}