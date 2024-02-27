using EntityFremework_Homework1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityFremework_Homework1.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Brand> Brands {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-U6B6T1F\\SQLEXPRESS;Database=ShopDb;Trusted_Connection=true;TrustServerCertificate=Yes");
        }
    }
}
