using Microsoft.EntityFrameworkCore;
using System;
using FakeXiecheng.Models;

namespace FakeXiecheng.Database
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppDb;");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

    }
}
