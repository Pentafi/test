using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PogoAdmin.Services;
using Services.Models;
using System;

namespace ASI.Basecode.WebApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthorService _authorService;
        private readonly ILogger<AuthorController> _logger; 

        public AuthorController(IMapper mapper, IAuthorService authorService, ILogger<AuthorController> logger) 
        {
            _mapper = mapper;
            _authorService = authorService;
            _logger = logger; 
        }


        public IActionResult Details(int id)
        {
            var viewModel = _authorService.GetAuthorById(id);
            if (viewModel == null)
            {
                _logger.LogWarning("Author with ID {AuthorId} not found.", id); 
                return NotFound();
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuthorViewModel model)
        {
            if (ModelState.IsValid)
            {
                _authorService.AddAuthor(model);
                _logger.LogInformation("Author created: {AuthorName} {LastName}", model.FirstName, model.LastName); 
                return RedirectToAction(nameof(Index));
            }
            _logger.LogWarning("Invalid model state for creating author."); 
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _authorService.GetAuthorById(id);
            if (viewModel == null)
            {
                _logger.LogWarning("Edit attempted for non-existent author with ID {AuthorId}.", id); 
                return NotFound();
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(AuthorViewModel model)
        {
            if (ModelState.IsValid)
            {
                _authorService.UpdateAuthor(model);
                _logger.LogInformation("Author updated: {AuthorId}", model.Id); 
                return RedirectToAction(nameof(Index));
            }
            _logger.LogWarning("Invalid model state for editing author with ID {AuthorId}.", model.Id); 
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _authorService.DeleteAuthor(id);
            _logger.LogInformation("Author deleted: {AuthorId}", id); 
            return RedirectToAction(nameof(Index));
        }
    }
}