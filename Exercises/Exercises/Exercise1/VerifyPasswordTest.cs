using NUnit.Framework;
using TestApp.Exercise_1.Exceptions;

namespace Exercises.Exercise1
{
    [TestFixture]
    public sealed class VerifyPasswordTest
    {
        private PasswordVerifier _passwordVerifier;

        [SetUp]
        public void SetUp()
        {
            _passwordVerifier = new PasswordVerifier();
        }


        [Test]
        public void ShouldThrowExceptionIfPasswordHasNotAtLeastEightCharacters()
        {
            // arrange
            const string password = "aaaaaa";

            // act

            // assert
            Assert.That(() => _passwordVerifier.Verify(password), Throws.InstanceOf<ToShortPasswordException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordIsNull()
        {
            // arrange
            const string password = null;

            // act

            // assert
            Assert.That(() => _passwordVerifier.Verify(password), Throws.InstanceOf<NullPasswordException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordHasNotUpperCase()
        {
            // arrange
            const string password = "tetssffffffffffff";

            // act

            // assert
            Assert.That(() => _passwordVerifier.Verify(password), Throws.InstanceOf<NoUpperCaseException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordHasNotLowerCase()
        {
            // arrange
            const string password = "HHHHHHHHHHHHHHHHHHHHHH";

            // act

            // assert
            Assert.That(() => _passwordVerifier.Verify(password), Throws.InstanceOf<NoLowerCaseException>());
        }
    }
}
