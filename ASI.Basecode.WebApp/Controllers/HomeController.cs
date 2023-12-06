using ASI.Basecode.Data;
using ASI.Basecode.Data.Models;
using ASI.Basecode.WebApp.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace ASI.Basecode.WebApp.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : ControllerBase<HomeController>
    {
        private readonly AsiBasecodeDBContext _dbContext; //test
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="configuration"></param>
        /// <param name="localizer"></param>
        /// <param name="mapper"></param>
        //public HomeController(IHttpContextAccessor httpContextAccessor,
        //                      ILoggerFactory loggerFactory,
        //                      IConfiguration configuration,
        //                      IMapper mapper = null) : base(httpContextAccessor, loggerFactory, configuration, mapper)
        //{

        //}
        public HomeController(
            IHttpContextAccessor httpContextAccessor,
            ILoggerFactory loggerFactory,
            IConfiguration configuration,
            AsiBasecodeDBContext dbContext,
            IMapper mapper = null
            ) : base(httpContextAccessor, loggerFactory, configuration, mapper)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// Returns Home View.
        /// </summary>
        /// <returns> Home View </returns>
        /// 

        public IActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            return View(books);
        }

        public IActionResult List()
        {
            var books = _dbContext.Books.ToList();
            //Book b = new() {
            //    Id = 1,
            //    Title = "Book1",
            //    Author = "Author1"
            //};
            //List<Book> booklist = new();

            //booklist.Add(b);    
            return View(books);
        }

        public IActionResult Details(int id)
        {
            // Fetch the book from the simulated data store
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            //var book = _books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
    }
}
