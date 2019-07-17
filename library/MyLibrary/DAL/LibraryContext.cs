using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyLibrary.Models;

namespace MyLibrary.DAL
{
    class LibraryContext:DbContext
    {
        public LibraryContext():base("LibraryContextData")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Custmer { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Report> Reports { get; set; }

    }
}
