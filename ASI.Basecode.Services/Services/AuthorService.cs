using Services.Models;
using AutoMapper;
using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using PogoAdmin.Services;
using ASI.Basecode.Data.Repositories;
using System.IO;
using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;

namespace ASI.Basecode.Services.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public IEnumerable<AuthorViewModel> GetAllAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return _mapper.Map<IEnumerable<AuthorViewModel>>(authors);
        }

        public AuthorViewModel GetAuthorById(int Id)
        {
            var author = _authorRepository.GetAuthorById(Id);
            return _mapper.Map<AuthorViewModel>(author);
        }

        public void AddAuthor(AuthorViewModel model)
        {
            if (!_authorRepository.AuthorExists(model.Id))
            {
                var author = _mapper.Map<Author>(model);
                _authorRepository.AddAuthor(author);
            }
            else
            {
                throw new InvalidDataException(Resources.Messages.Errors.UserExists);
            }
        }

        public void UpdateAuthor(AuthorViewModel model)
        {
            if (_authorRepository.AuthorExists(model.Id))
            {
                var existingAuthor = _authorRepository.GetAuthorById(model.Id);
                _mapper.Map(model, existingAuthor);
                _authorRepository.UpdateAuthor(existingAuthor);
            }
        }

        public void DeleteAuthor(int Id)
        {
            _authorRepository.DeleteAuthor(Id);
        }
    }
}