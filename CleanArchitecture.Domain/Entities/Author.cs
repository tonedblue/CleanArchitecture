using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Entities
{
    public partial class Author
    {
        public Author() { }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
