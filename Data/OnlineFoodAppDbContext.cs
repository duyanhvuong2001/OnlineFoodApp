using Microsoft.EntityFrameworkCore;
using OnlineFoodApp.Models;

namespace OnlineFoodApp.Data
{
    public class OnlineFoodAppDbContext : DbContext
    {
        public OnlineFoodAppDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        
    }
}
