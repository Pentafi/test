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
            new Author() { FirstName = "Justinwapo", LastName = "Gabison"},
            new Author() { FirstName = "Renz", LastName = "Nunez" },
            new Author() { FirstName = "Vaughn", LastName = "Tahadlangit" }
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
            new Genre() { Name = "Fiction" },
            new Genre() { Name = "Non-Fiction" },
            new Genre() { Name = "Dystopia" },
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
                Name = "Pokemon X and Y",
                Description = "Lorem ipsum dolor sit amet. Ex galisum expedita quo sunt consequatur et cupiditate vitae vel molestiae nostrum et velit sequi. Ut quae nihil qui officia quasi et aliquam doloribus hic earum impedit et doloribus repellendus.\\r\\n\\r\\nEt deleniti praesentium ut quisquam blanditiis et tempora sint ea illum placeat. Et sunt quos et maxime consectetur qui officiis iusto non beatae ipsum ut recusandae facere nam impedit dolorum.\\r\\n\\r\\nId optio voluptatem ad minus reiciendis sit iure impedit qui quibusdam totam aut enim illum. Sed temporibus Quis est maiores quae ut placeat tempore 33 maxime molestiae et omnis similique sed internos blanditiis!\",",
                PubDate = new DateTime(1960, 7, 11),
                ImageUrl = "https://assets.pokemon.com/assets/cms2/img/video-games/_tiles/pokemon-xy/pokemon-xy-launch-169.jpg"
            },
            new Book()
            {
                Name = "Pokemon Black and White",
                Description = "Lorem ipsum dolor sit amet. Ex galisum expedita quo sunt consequatur et cupiditate vitae vel molestiae nostrum et velit sequi. Ut quae nihil qui officia quasi et aliquam doloribus hic earum impedit et doloribus repellendus.\\r\\n\\r\\nEt deleniti praesentium ut quisquam blanditiis et tempora sint ea illum placeat. Et sunt quos et maxime consectetur qui officiis iusto non beatae ipsum ut recusandae facere nam impedit dolorum.\\r\\n\\r\\nId optio voluptatem ad minus reiciendis sit iure impedit qui quibusdam totam aut enim illum. Sed temporibus Quis est maiores quae ut placeat tempore 33 maxime molestiae et omnis similique sed internos blanditiis!\",",
                PubDate = new DateTime(2022, 3, 12),
                ImageUrl = "https://www.trustedreviews.com/wp-content/uploads/sites/54/2016/12/pokemon-sun-6-1.jpg"
            },
            new Book()
            {
                Name = "Pokemon Red, Blue, and Yellow",
                Description = "Lorem ipsum dolor sit amet. Ex galisum expedita quo sunt consequatur et cupiditate vitae vel molestiae nostrum et velit sequi. Ut quae nihil qui officia quasi et aliquam doloribus hic earum impedit et doloribus repellendus.\\r\\n\\r\\nEt deleniti praesentium ut quisquam blanditiis et tempora sint ea illum placeat. Et sunt quos et maxime consectetur qui officiis iusto non beatae ipsum ut recusandae facere nam impedit dolorum.\\r\\n\\r\\nId optio voluptatem ad minus reiciendis sit iure impedit qui quibusdam totam aut enim illum. Sed temporibus Quis est maiores quae ut placeat tempore 33 maxime molestiae et omnis similique sed internos blanditiis!\",",
                PubDate = new DateTime(1949, 6, 8),
                ImageUrl = "https://ragglefragglereviews.files.wordpress.com/2021/09/maxresdefault-2.jpg?w=1200"
            }
        };
                asiBasecodeDBContext.Books.AddRange(books);
                asiBasecodeDBContext.SaveChanges();
            }
        }

        //private void SeedAuthors()
        //{
        //    if (!asiBasecodeDBContext.Authors.Any())
        //    {
        //        var authors = new List<Author>
        //        {
        //            new Author() { Id = 1, FirstName = "Justinwapo", LastName = "Gabison"},
        //            new Author() { Id = 2, FirstName = "Renz", LastName = "Nunez" },
        //            new Author() { Id = 3, FirstName = "Vaughn", LastName = "Tahadlangit" }
        //        };
        //        asiBasecodeDBContext.Authors.AddRange(authors);
        //        asiBasecodeDBContext.SaveChanges();
        //    }
        //}

        //private void SeedGenres()
        //{
        //    if (!asiBasecodeDBContext.Genres.Any())
        //    {
        //        var genres = new List<Genre>
        //        {
        //            new Genre() { Id = 1, Name = "Fiction" },
        //            new Genre() { Id = 2, Name = "Non-Fiction" },
        //            new Genre() { Id = 3, Name = "Dystopia" },
        //        };
        //        asiBasecodeDBContext.Genres.AddRange(genres);
        //        asiBasecodeDBContext.SaveChanges();
        //    }
        //}

        //private void SeedBooks()
        //{
        //    if (!asiBasecodeDBContext.Books.Any())
        //    {
        //        var books = new List<Book>
        //        {
        //            new Book() 
        //            { 
        //                Id = 1,
        //                Name = "To Kill a Mockingbird",
        //                Description = "A classic novel by Harper Lee.",
        //                PubDate = new DateTime(1960, 7, 11),
        //                image = File.ReadAllBytes("path/to/your/image.jpg"),
        //            },
        //            new Book()
        //            {
        //                Id = 2,
        //                Name = "Pokeball",
        //                Description = "Catch anything",
        //                PubDate = new DateTime(2022, 3, 12),
        //                image = File.ReadAllBytes("path/to/your/image.jpg"),
        //            },
        //            new Book()
        //            {
        //                Id = 3,
        //                Name = "1984",
        //                Description = "A dystopian novel by George Orwell.",
        //                PubDate = new DateTime(1949, 6, 8),
        //                image = File.ReadAllBytes("path/to/your/image.jpg"),
        //            }
        //        };
        //        asiBasecodeDBContext.Books.AddRange(books);
        //        asiBasecodeDBContext.SaveChanges();
        //    }
        //}
    }
}
