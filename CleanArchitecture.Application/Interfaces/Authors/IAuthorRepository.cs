using CleanArchitecture.Application.Entities;
using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Authors
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<AuthorDal>> GetAllAsync();
        Task<bool> InsertAsync(AuthorDal author);
        Task<bool> UpdateAsync(AuthorDal author);
        Task<bool> DeleteAsync(AuthorDal author);
    }
}
