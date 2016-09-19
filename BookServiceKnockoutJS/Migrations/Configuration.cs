namespace BookServiceKnockoutJS.Migrations
{
    using BookServiceKnockoutJS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookServiceKnockoutJS.Models.BookServiceKnockoutJSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookServiceKnockoutJS.Models.BookServiceKnockoutJSContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() { Id = 1, Name = "Nora Roberts" },
                new Author() { Id = 2, Name = "Sidney Sheldon" },
                new Author() { Id = 3, Name = "Arthur C Doyle" });

            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, AuthorId = 1, Genre = "Novel", Price = 112, Title = "My Novel", Year = 1990 },
                new Book() { Id = 2, AuthorId = 1, Genre = "Novel", Price = 120, Title = "My Novel 2", Year = 1999 },
                new Book() { Id = 3, AuthorId = 2, Genre = "Romance", Price = 122, Title = "My Romance 1", Year = 1940 },
                new Book() { Id = 4, AuthorId = 2, Genre = "Romance", Price = 142, Title = "My Romance 2", Year = 1945 },
                new Book() { Id = 5, AuthorId = 2, Genre = "Romance", Price = 125, Title = "My Romance 3", Year = 1965 },
                new Book() { Id = 6, AuthorId = 3, Genre = "Police Romance", Price = 162, Title = "My Police Romance 1", Year = 2012 });

        }
    }
}
