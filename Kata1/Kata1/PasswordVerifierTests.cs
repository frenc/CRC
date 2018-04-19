using NUnit.Framework;
using TestApp.Exercise_1.Exceptions;

namespace TestApp.Exercise_1
{
    [TestFixture]
    public sealed class VerifyTests
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
            const string password = "aaaaaa";

            // act
            void Execute()
            {
                _passwordVerifier.Verify(password);
            }

            // assert
            Assert.That(Execute, Throws.InstanceOf<ToShortPasswordException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordIsNull()
        {
            // arrange
            const string password = null;

            // act
            void Execute()
            {
                _passwordVerifier.Verify(password);
            }

            // assert
            Assert.That(Execute, Throws.InstanceOf<NullPasswordException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordHasNotUpperCase()
        {
            // arrange
            const string password = "tetssffffffffffff";

            // act
            void Execute()
            {
                _passwordVerifier.Verify(password);
            }

            // assert
            Assert.That(Execute, Throws.InstanceOf<NoUpperCaseException>());
        }

        [Test]
        public void ShouldThrowExceptionIfPasswordHasNotLowerCase()
        {
            // arrange
            const string password = "HHHHHHHHHHHHHHHHHHHHHH";

            // act
            void Execute()
            {
                _passwordVerifier.Verify(password);
            }

            // assert
            Assert.That(Execute, Throws.InstanceOf<NoLowerCaseException>());
        }
    }
}
