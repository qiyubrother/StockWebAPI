using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace StockDatabase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DataContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=stock;uid=root;pwd=123456;SslMode=none;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(t => new { t.UserName });
            modelBuilder.Entity<Goods>().HasKey(t => new { t.GoodsId });
            modelBuilder.Entity<Client>().HasKey(t => new { t.ClientId });
            //modelBuilder.Entity<Client>().HasKey(t => new { t.HotelId, t.Mobile, t.ReservationNo });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
