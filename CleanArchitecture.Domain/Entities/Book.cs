using CleanArchitecture.Domain.ValueObjects;

namespace CleanArchitecture.Domain.Entities
{
    public partial class Book
    {
        public Book() { }

        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Isbn Isbn { get; set; }
    }
}
