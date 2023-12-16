﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using MarketManagementSystem.Entity;

namespace MarketManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DbConnection") { }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<SellProduct> SellProduct { get; set; }
        public DbSet<BuyProduct> BuyProduct { get; set; }

    }
}
