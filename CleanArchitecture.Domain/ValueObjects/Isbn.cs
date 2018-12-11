using CleanArchitecture.Domain.Exceptions;
using System;

namespace CleanArchitecture.Domain.ValueObjects
{
    public class Isbn
    {
        public Isbn(string isbnNumber)
        {
            if (!isValidIsbn(isbnNumber))
            {
                throw new IsbnInvalidException(isbnNumber, new Exception());
            }

            this.IsbnNumber = isbnNumber;
        }

        public string IsbnNumber { get; private set; }

        bool isValidIsbn(string isbnNumber)
        {
            return (isbnNumber.Length == 10);
        }

    }
}
