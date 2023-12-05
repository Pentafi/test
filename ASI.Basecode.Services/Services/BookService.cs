using ASI.Basecode.Data.Repositories;
using AutoMapper;
using ASI.Basecode.Services.Interfaces;
using Services.ServiceModels;
using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using PogoAdmin.Services;
using System.IO;
using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;

namespace Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public IEnumerable<BookViewModel> GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            return _mapper.Map<IEnumerable<BookViewModel>>(books);
        }

        public BookViewModel GetBookById(int Id)
        {
            var book = _bookRepository.GetBookById(Id);
            return _mapper.Map<BookViewModel>(book);
        }

        public void AddBook(BookViewModel model)
        {
            if (!_bookRepository.BookExists(model.Id))
            {
                var book = _mapper.Map<Book>(model);
                _bookRepository.AddBook(book);
            }
            else
            {
                throw new InvalidDataException("Book with the provided ID already exists.");
            }
        }

        public void UpdateBook(BookViewModel model)
        {
            if (_bookRepository.BookExists(model.Id))
            {
                var existingBook = _bookRepository.GetBookById(model.Id);
                _mapper.Map(model, existingBook);
                _bookRepository.UpdateBook(existingBook);
            }
        }

        public void DeleteBook(int Id)
        {
            _bookRepository.DeleteBook(Id);
        }
    }
}