using CleanArchitecture.Application.Configurations;
using CleanArchitecture.Application.Entities;
using CleanArchitecture.Application.Interfaces.Authors;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models.Authors.CreateAuthor.Commands
{
    public class CreateAuthorHandler : IRequestHandler<CreateAuthorCommand, Unit>
    {
        private readonly IAuthorRepository authorRepository;

        //TODO dependency injection
        public CreateAuthorHandler(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<Unit> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = Mapping.Mapper.Map<AuthorDal>(request);
            await authorRepository.InsertAsync(author);
            return Unit.Value;
        }
    }
}
