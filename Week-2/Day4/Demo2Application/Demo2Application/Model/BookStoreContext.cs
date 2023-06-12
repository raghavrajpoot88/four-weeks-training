
using System.Collections.Generic;

namespace Demo2Application.Model 
{
        public class BookStoreContext : DbContext
        {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        public DbSet<BookStore> bookStores { get; set; } = null!;

        public string DbPath { get; }
        } 
}

