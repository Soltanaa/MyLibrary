namespace MyLibrary.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MyLibrary.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyLibrary.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyLibrary.DAL.LibraryContext context)
        {
            var people = new List<Customer>
            {
                new Customer{FullName = "Nurlan Pasazade",PhoneNumber = "0553399930"},
                new Customer{FullName = "Ilqar Memmedov",PhoneNumber = "0705603535"},
                new Customer{FullName = "Elxan Qocayev",PhoneNumber = "0583399930"}
            };
            context.Custmer.AddRange(people);
            context.SaveChanges();


            var books = new List<Book>
            {
                new Book{Name="Eloquent Javascript",BookCount=3,Price=10},
                new Book { Name = "Pro C# 7", BookCount = 5, Price = 20},
                new Book { Name = "Beginning T-SQL", BookCount = 2, Price = 15}
            };
            context.Books.AddRange(books);
            context.SaveChanges();


            var orders = new List<Order>
            {
                new Order{CustomerId=1},
                new Order{CustomerId=2},
                new Order{  CustomerId=3}
            };
            context.Orders.AddRange(orders);
            context.SaveChanges();

            var reports = new List<Report>
            {
                new Report{IsPaid=false,BookId=1,Paydate = DateTime.Now.AddDays(10), BookingTime=DateTime.Now,OrderId=1},
                new Report{IsPaid=false,BookId=2,Paydate = DateTime.Now.AddDays(6), BookingTime=DateTime.Now,OrderId=3},
                new Report{IsPaid=false,BookId=3,Paydate = DateTime.Now.AddDays(4), BookingTime=DateTime.Now,OrderId=2}
            };
            context.Reports.AddRange(reports);
            context.SaveChanges();
            
            var Admin = new List<Admin>
            {
                new Admin{UserName = "Admin",Password = "12345" }
            };
            context.Admins.AddRange(Admin);

            context.SaveChanges();
        }
    }
}
