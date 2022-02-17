#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookList.Models;

namespace BookList.Data
{
    public class BookListContext : DbContext
    {
        public BookListContext (DbContextOptions<BookListContext> options)
            : base(options)
        {
        }

        public DbSet<BookList.Models.Books> Books { get; set; }
    }
}
