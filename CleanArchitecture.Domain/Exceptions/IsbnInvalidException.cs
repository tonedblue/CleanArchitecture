using System;

namespace CleanArchitecture.Domain.Exceptions
{
    public class IsbnInvalidException : Exception
    {
        public IsbnInvalidException(string isbn, Exception ex)
        : base($"ISBN \"{isbn}\" is invalid.", ex)
        {
        }
    }
}
