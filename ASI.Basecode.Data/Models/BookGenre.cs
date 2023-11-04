using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public partial class BookGenre
    {
        public int BookId { get; set; }
        [Key]
        public int GenreId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
