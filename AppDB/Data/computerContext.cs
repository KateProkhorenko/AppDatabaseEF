using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AppDB.Models;

#nullable disable

namespace AppDB.Data
{
    public class computerContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Pc> Pcs { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=computer;Trusted_Connection=True;");
            }
        }

       
    }
}
