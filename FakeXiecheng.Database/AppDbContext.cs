using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using FakeXiecheng.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FakeXiecheng.Database
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FakeXiechengDb;");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TouristRoute>().HasData(new TouristRoute()
            //{
            //    Id=Guid.NewGuid(),
            //    Title="abcd",
            //    Description="shuoming",
            //    OriginalPrice=0,
            //    CreateTime=DateTime.UtcNow

            //});

            var touristRouteJsonData = File.ReadAllText(
                @"J:\MIS\FakeXiecheng2\FakeXiecheng\FakeXiecheng.Database\touristRoutesMockData.json");
            var touristRoutes
                = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJsonData);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);

            var touristRoutePictureJsonData = File.ReadAllText(
                @"J:\MIS\FakeXiecheng2\FakeXiecheng\FakeXiecheng.Database\touristRoutePicturesMockData.json");
            var touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePictureJsonData);
            modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

    }
}
