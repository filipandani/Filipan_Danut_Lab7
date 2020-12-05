using Filipan_Danut_Lab2.Models;
using Filipan_Danut_Lab2.Views.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Danut_Lab2.Data
{
    public class LibraryContext :DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<PublishedBooks> PublishedBooks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Books>().ToTable("Book");
            modelBuilder.Entity<Publishers>().ToTable("Publisher");
            modelBuilder.Entity<PublishedBooks>().ToTable("PublishedBooks");
            modelBuilder.Entity<PublishedBooks>().HasKey(c => new { c.BookID, c.PublisherID });
        }
    }
}
