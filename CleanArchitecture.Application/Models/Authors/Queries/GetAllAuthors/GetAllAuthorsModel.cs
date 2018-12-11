using MediatR;
using System;

namespace CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries
{
    public class GetAllAuthorsModel : IRequest
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
