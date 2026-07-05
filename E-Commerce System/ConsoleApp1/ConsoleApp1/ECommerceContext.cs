using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1.models;

using System.Text;
using Microsoft.Extensions.Options;

namespace ConsoleApp1
{
    public  class ECommerceContext:DbContext
    {
        public DbSet<Category>Categorys { get; set; }
        public DbSet<Product> Products{ get; set;  }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server =localhost; Database= ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True; ");
        }
    }
}
