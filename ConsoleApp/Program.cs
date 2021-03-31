using System;
using FakeXiecheng.Database;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            var context = new AppDbContext();
            //context.Database.EnsureCreated();
        }
    }
}
