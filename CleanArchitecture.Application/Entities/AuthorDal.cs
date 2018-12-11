using CleanArchitecture.Domain.Entities;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Application.Entities
{
    [Dapper.Contrib.Extensions.Table("Author")]
    public partial class AuthorDal : Author
    {
        [Dapper.Contrib.Extensions.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public new int AuthorId { get; set; }

        [Computed]
        public new IEnumerable<Book> Books { get; set; }

    }
}
