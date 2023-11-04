using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public partial class AuthorBooks
    {
        public int AuthorBooksId { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
