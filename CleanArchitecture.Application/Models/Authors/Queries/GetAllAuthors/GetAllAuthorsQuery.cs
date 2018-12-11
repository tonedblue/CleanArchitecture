using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries
{
    public class GetAllAuthorsQuery : IRequest<IEnumerable<GetAllAuthorsModel>>
    {
    }
}
