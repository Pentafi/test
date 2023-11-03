﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Models
{
    public partial class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Many-to-Many relationship
        public virtual ICollection<AuthorBook> AuthorBooks { get; set; } = new List<AuthorBook>();
    }
}
