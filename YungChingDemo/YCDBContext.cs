using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography;
using YungChingDemo.Models;

namespace YungChingDemo
{
    public class YCDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=mydatabase.db");

        }

        public YCDBContext(DbContextOptions<YCDBContext> options)
      : base(options)
        {
        }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Orders> orders { get; set; }

    }

}

