using CleanArchitecture.Application.Configurations;
using CleanArchitecture.Application.Entities;
using CleanArchitecture.Application.Interfaces.Authors;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models.Authors.Commands.UpdateAuthor
{
    public class UpdateAuthorHandler : IRequestHandler<UpdateAuthorCommand, Unit>
    {
        private readonly IAuthorRepository authorRepository;

        //TODO dependency injection
        public UpdateAuthorHandler(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = Mapping.Mapper.Map<AuthorDal>(request);
            await authorRepository.UpdateAsync(author);
            return Unit.Value;
        }
    }
}
