using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public class DataSeeder
    {
        private readonly AsiBasecodeDBContext asiBasecodeDBContext;

        public DataSeeder(AsiBasecodeDBContext asiBasecodeDBContext)
        {
            this.asiBasecodeDBContext = asiBasecodeDBContext;
        }

        public void Seed()
        {
            SeedAuthors();
            SeedGenres();
            SeedBooks();
        }

        private void SeedAuthors()
        {
            if (!asiBasecodeDBContext.Authors.Any())
            {
                var authors = new List<Author>
                {
                    new Author() { Id = 1, FirstName = "Justinwapo", LastName = "Gabison"},
                    new Author() { Id = 2, FirstName = "Renz", LastName = "Nunez" },
                    new Author() { Id = 3, FirstName = "Vaughn", LastName = "Tahadlangit" }
                };
                asiBasecodeDBContext.Authors.AddRange(authors);
                asiBasecodeDBContext.SaveChanges();
            }
        }

        private void SeedGenres()
        {
            if (!asiBasecodeDBContext.Genres.Any())
            {
                var genres = new List<Genre>
                {
                    new Genre() { Id = 1, Name = "Fiction" },
                    new Genre() { Id = 2, Name = "Non-Fiction" },
                    new Genre() { Id = 3, Name = "Dystopia" },
                };
                asiBasecodeDBContext.Genres.AddRange(genres);
                asiBasecodeDBContext.SaveChanges();
            }
        }

        private void SeedBooks()
        {
            if (!asiBasecodeDBContext.Books.Any())
            {
                var books = new List<Book>
                {
                    new Book() 
                    { 
                        Id = 1,
                        Name = "To Kill a Mockingbird",
                        Description = "A classic novel by Harper Lee.",
                        PubDate = new DateTime(1960, 7, 11),
                        image = File.ReadAllBytes("path/to/your/image.jpg"),
                    },
                    new Book()
                    {
                        Id = 2,
                        Name = "Pokeball",
                        Description = "Catch anything",
                        PubDate = new DateTime(2022, 3, 12),
                        image = File.ReadAllBytes("path/to/your/image.jpg"),
                    },
                    new Book()
                    {
                        Id = 3,
                        Name = "1984",
                        Description = "A dystopian novel by George Orwell.",
                        PubDate = new DateTime(1949, 6, 8),
                        image = File.ReadAllBytes("path/to/your/image.jpg"),
                    }
                };
                asiBasecodeDBContext.Books.AddRange(books);
                asiBasecodeDBContext.SaveChanges();
            }
        }
    }
}
