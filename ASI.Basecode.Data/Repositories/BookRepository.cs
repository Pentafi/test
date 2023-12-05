using System;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Data.Interfaces;
using Basecode.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASI.Basecode.Data.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public BookRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Book> GetAllBooks()
        {
            return this.GetDbSet<Book>().Include(b => b.AuthorBooks)
                           .ThenInclude(ab => ab.Author)
                       .Include(b => b.BookGenres)
                           .ThenInclude(bg => bg.Genre);
        }
        public Book GetBookById(int id)
        {
            return this.GetDbSet<Book>().Include(b => b.AuthorBooks)
                           .ThenInclude(ab => ab.Author)
                       .Include(b => b.BookGenres)
                           .ThenInclude(bg => bg.Genre)
                       .FirstOrDefault(b => b.Id == id);
        }

        public bool BookExists(int bookId)
        {
            return this.GetDbSet<Book>().Any(x => x.Id == bookId);
        }

        public void AddBook(Book book)
        {
            this.GetDbSet<Book>().Add(book);
            UnitOfWork.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            this.SetEntityState(book, EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = this.GetBookById(id);
            if (book != null)
            {
                this.GetDbSet<Book>().Remove(book);
                UnitOfWork.SaveChanges();
            }
        }
        public IQueryable<Genre> GetGenreByBook(int bookId)
        {
            var bookGenres = this.GetDbSet<BookGenre>()
                .Include(bg => bg.Genre)
                .Where(bg => bg.BookId == bookId)
                .Select(bg => bg.Genre);

            return bookGenres;
        }
        public IQueryable<Book> GetBookByAuthorId(int authorId)
        {
            return this.GetDbSet<Book>().Include(b => b.AuthorBooks)
                       .Where(ab => ab.AuthorBooks.Any(a => a.AuthorId == authorId))
                       .Include(b => b.BookGenres)
                       .ThenInclude(bg => bg.Genre);
        }
    }
}
