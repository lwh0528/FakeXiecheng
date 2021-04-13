using System;
using System.IO;
using System.Linq;
using System.Reflection;
using FakeXiecheng.Database;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            //context.Database.EnsureCreated();

            var c=context.TouristRoutePictures.ToList();
            
        }
    }
}
