using NUnit.Framework;
using TestApp.Exercise_1.Exceptions;

namespace Exercises.Exercise1
{
    [TestFixture]
    public sealed class ComparePasswordsTest
    {
        private PasswordVerifier _passwordVerifier;

        [SetUp]
        public void SetUp()
        {
            _passwordVerifier = new PasswordVerifier();
        }

        [TestCase("Pass", "Pass", true)]
        [TestCase("Test", "Test", true)]
        [TestCase("Test", "Test1", false)]
        [TestCase("Test", "TesT", false)]
        public void ItShouldComparePasswords(string password1, string password2, bool expectedResult)
        {
            // arrange

            // act
            var result = _passwordVerifier.Compare(password1, password2);

            // assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase("", "Test1")]
        [TestCase("Test", "")]
        [TestCase("Test", null)]
        [TestCase(null, "dsd")]
        public void ShouldThrowExceptionIfPasswordsAreNullOrEmpty(string password1, string password2)
        {
            // arrange

            // act
            void Execute()
            {
                _passwordVerifier.Compare(password1, password2);
            }

            // assert
            Assert.That(Execute, Throws.InstanceOf<NullPasswordException>());
        }
    }
}
