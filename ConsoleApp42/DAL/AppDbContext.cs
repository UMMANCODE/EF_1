using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp42.Models;

namespace ConsoleApp42.DAL {
    internal class AppDbContext : DbContext {

        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DELL-UMMAN\SQLEXPRESS;Database=Techno;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
