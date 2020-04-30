using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookStoreContext:DbContext
    {
        //DB tablosu ile entity eşleştirme

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookStore;Trusted_Connection=true");
        }

        public DbSet<Book> Books { get; set; } 
    }
}
