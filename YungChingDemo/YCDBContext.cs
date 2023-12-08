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
            // //Replace with your connection string.
            // var builder = new ConfigurationBuilder()
            //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            // IConfiguration config = builder.Build();

            // var host = config.GetSection("ConntectionString").GetSection("SQL").Value;
            // var port = config.GetSection("ConntectionString").GetSection("Port").Value;
            // var password = config.GetSection("ConntectionString").GetSection("Password").Value;

            // var connectionString = $"Server={host}:{port}; Database=YCDB; User Id=sa; Password={password};";
            // optionsBuilder
            //     .UseSqlite(connectionString)
            //     .EnableDetailedErrors();
        }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Orders> orders { get; set; }

    }

}

