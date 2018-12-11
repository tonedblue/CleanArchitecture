using CleanArchitecture.Domain.Entities;
using FluentValidation;

namespace CleanArchitecture.Persistence.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(m => m.Name).NotEmpty().Length(1, 100);
        }
    }
}
