using CleanArchitecture.Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Books
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookDal>> GetAllAsync();
        Task<bool> InsertAsync(BookDal book);
        Task<bool> UpdateAsync(BookDal book);
        Task<bool> DeleteAsync(BookDal book);
    }
}
