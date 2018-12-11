using CleanArchitecture.Domain.Entities;
using FluentValidation;

namespace CleanArchitecture.Persistence.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(m => m.Title).NotEmpty().Length(1, 100);
            RuleFor(m => m.Description).NotEmpty().Length(1, 500);
            RuleFor(m => m.Isbn).NotEmpty();
        }
    }
}
