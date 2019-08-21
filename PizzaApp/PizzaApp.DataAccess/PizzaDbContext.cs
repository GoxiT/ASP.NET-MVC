using Microsoft.EntityFrameworkCore;
using PizzaApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.DataAccess
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cofigure relations among entities
            modelBuilder.Entity<Order>()
                .HasMany(x => x.Pizzas)
                .WithOne(x => x.Order);

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    Address = "Partizanski Ordredi br. 24",
                    Name = "Martin Panovski",
                    Phone = "243243242"
                },
                new Order
                {
                    Id = 2,
                    Address = "Pariska 9A",
                    Name = "Dejan Jovanov",
                    Phone = "243243242"
                }
            );
        }
    }
}
