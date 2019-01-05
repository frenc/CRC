using System;
using System.Linq;
using TestApp.Exercise_1.Exceptions;

namespace Exercises.Exercise1
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

            if (!password.Any(char.IsUpper))
            {
                throw new NoUpperCaseException();
            }

            if (!password.Any(char.IsLower))
            {
                throw new NoLowerCaseException();
            }

            if (!password.Any(char.IsDigit))
            {
                throw new NoDigitException();
            }
        }
    }
}