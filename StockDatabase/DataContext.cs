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
            modelBuilder.Entity<Reservation>().HasKey(t => new { t.HotelId, t.ReservationNo });
            modelBuilder.Entity<Authentication>().HasKey(t => new { t.HotelId, t.Mobile, t.ReservationNo });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
    }
}
