using System.Collections.Generic;
using ASI.Basecode.Services.Models;
using Services.ServiceModels;

namespace ASI.Basecode.Services.Models
{
    public class BookDetailsViewModel
    {
        public BookViewModel Book { get; set; }
        public List<BookViewModel> AllBooks { get; set; } 
        public BookViewModel[] RelatedBooks { get; set; }


    }
}