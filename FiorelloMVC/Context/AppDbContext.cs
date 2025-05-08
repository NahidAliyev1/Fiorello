
using System.Collections.Generic;
using FiorelloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVC.Contexts
{


    public class AppDbContext : DbContext
    {
        private readonly string _connectionString = "Server=WINDOWS-AEJTJIB;Database=FiorelloDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public DbSet<SliderItem> SliderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
