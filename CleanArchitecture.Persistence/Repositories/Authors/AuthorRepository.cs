using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Dapper.Contrib.Extensions;
using CleanArchitecture.Application.Interfaces.Authors;
using CleanArchitecture.Application.Entities;

namespace CleanArchitecture.Persistence.Repositories.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        ConnectionFactory connectionFactory { get; set; }

        public AuthorRepository()
        {
            this.connectionFactory = new ConnectionFactory();
        }

        public async Task<IEnumerable<AuthorDal>> GetAllAsync()
        {
            using (var connection = connectionFactory.CreateConnection())
            {
                return await connection.GetAllAsync<AuthorDal>();
            }
        }
        public async Task<bool> InsertAsync(AuthorDal author)
        {
            using (var connection = connectionFactory.CreateConnection())
            {
                try
                {
                    var result = await connection.InsertAsync<AuthorDal>(author);
                    return result != 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                    return false;
                }
            }
        }

        public async Task<bool> UpdateAsync(AuthorDal author)
        {
            using (var connection = connectionFactory.CreateConnection())
            {
                var result = await connection.UpdateAsync(author);
                return result;
            }
        }
        public async Task<bool> DeleteAsync(AuthorDal author)
        {
            using (var connection = connectionFactory.CreateConnection())
            {
                var result = await connection.DeleteAsync(author);
                return result;
            }
        }
    }
}
