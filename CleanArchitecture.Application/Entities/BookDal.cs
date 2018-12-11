using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Application.Entities
{
    [Dapper.Contrib.Extensions.Table("Book")]
    public partial class BookDal
    {
        [Dapper.Contrib.Extensions.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Computed]
        public int AuthorId { get; set; }
    }
}
