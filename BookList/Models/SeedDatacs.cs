using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookList.Data;
using System;
using System.Linq;

namespace BookList.Models //This seed data replaces the movies seed data - this runs when we add a scope to the main Program.cs file (using statement l. 4 and lines 15-20) 
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookListContext>>()))
            {
                // Look for any books in the database already - if there is data, this won't run.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                    new Books
                    {
                        Title = "Mort",
                        AuthorLast = "Pratchett",
                        AuthorFirst = "Terry",
                        Date = DateTime.Parse("01/01/1987"),
                        Genre = "Fantasy",
                        Rating = "*****"

                    },

                    new Books
                    {
                        Title = "Guards, Guards!",
                        AuthorLast = "Pratchett",
                        AuthorFirst = "Terry",
                        Date = DateTime.Parse("01/01/1989"),
                        Genre = "Fantasy",
                        Rating = "*****"

                    },

                    new Books
                    {
                        Title = "Hogfather",
                        AuthorLast = "Pratchett",
                        AuthorFirst = "Terry",
                        Date = DateTime.Parse("01/01/1996"),
                        Genre = "Fantasy",
                        Rating = "*****"

                    },



                    new Books
                    {
                        Title = "Equal Rites",
                        AuthorLast = "Pratchett",
                        AuthorFirst = "Terry",
                        Date = DateTime.Parse("01/01/1987"),
                        Genre = "Fantasy",
                        Rating = "*****"
                    }



                );
                context.SaveChanges();
            }
        }
    }
}

