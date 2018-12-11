using CleanArchitecture.Application.Entities;
using CleanArchitecture.Application.Interfaces.Books;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories.Books
{
    public class BookRepository : IBookRepository
    {
        ConnectionFactory connectionFactory { get; set; }

        public BookRepository()
        {
            this.connectionFactory = new ConnectionFactory();
        }

        public async Task<IEnumerable<BookDal>> GetAllAsync() {
            using (var connection = connectionFactory.CreateConnection())
            {
                return await connection.GetAllAsync<BookDal>();
            }
        }
        public async Task<bool> InsertAsync(BookDal book) {
            using (var connection = connectionFactory.CreateConnection())
            {
                try
                {
                    var result = await connection.InsertAsync<BookDal>(book);
                    return result != 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                    return false;
                }
            }
        }
        public async Task<bool> UpdateAsync(BookDal book) {
            using (var connection = connectionFactory.CreateConnection())
            {
                var result = await connection.UpdateAsync(book);
                return result;
            }
        }
        public async Task<bool> DeleteAsync(BookDal book) {
            using (var connection = connectionFactory.CreateConnection())
            {
                var result = await connection.DeleteAsync(book);
                return result;
            }
        }

    }
}
