using System;
using ASI.Basecode.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAllAuthors();
        Author GetAuthorById(int Id);
        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int Id);
        bool AuthorExists(int Id);
    }
}
