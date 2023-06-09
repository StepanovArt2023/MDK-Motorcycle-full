﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_Motorcycle.Model
{
    public class ModelDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Motorcycle.db");
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}