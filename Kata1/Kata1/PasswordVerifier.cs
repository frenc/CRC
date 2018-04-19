using System;
using System.Linq;
using TestApp.Exercise_1.Exceptions;

namespace TestApp.Exercise_1
{
    public sealed class PasswordVerifier
    {
        public void Verify(string password)
        {
            if (password == null)
            {
                throw new NullPasswordException();
            }

            if (password.Length < 9)
            {
                throw new ToShortPasswordException();
            }

            if (!password.Any(Char.IsUpper))
            {
                throw new NoUpperCaseException();
            }

            if (!password.Any(Char.IsLower))
            {
                throw new NoLowerCaseException();
            }

            if (!password.Any(Char.IsDigit))
            {
                throw new NoDigitException();
            }
        }
    }
}
