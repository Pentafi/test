using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public partial class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Many-to-Many relationship
        public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
