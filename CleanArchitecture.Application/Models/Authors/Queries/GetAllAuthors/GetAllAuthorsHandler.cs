using CleanArchitecture.Application.Configurations;
using CleanArchitecture.Application.Interfaces.Authors;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries
{
    public class GetAllAuthorsHandler : IRequestHandler<GetAllAuthorsQuery, IEnumerable<GetAllAuthorsModel>>
    {
        private readonly IAuthorRepository authorRepository;

        //TODO dependency injection
        public GetAllAuthorsHandler(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<IEnumerable<GetAllAuthorsModel>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var authors = await authorRepository.GetAllAsync();
            return Mapping.Mapper.Map<IEnumerable<GetAllAuthorsModel>>(authors);
        }
    }
}
