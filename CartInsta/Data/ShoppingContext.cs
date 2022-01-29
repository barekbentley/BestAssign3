using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CartInsta.Models;

namespace CartInsta.Data
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext (DbContextOptions<ShoppingContext> options)
            : base(options)
        {
        }

        public DbSet<CartInsta.Models.User> Users { get; set; }
        public DbSet<CartInsta.Models.Order> Orders { get; set; }
        public DbSet<CartInsta.Models.DeliveryPerson> DeliveryPersons { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeliveryPerson>().ToTable("DeliveryPerson");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
