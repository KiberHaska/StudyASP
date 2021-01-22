using System;
using System.Collections.Generic;
using System.Text;
using AspLevel1.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPlevel1.DAL
{
    public class ASPlevel1Context : IdentityDbContext<User>
    {
        public ASPlevel1Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
