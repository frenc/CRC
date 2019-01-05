using NUnit.Framework;

namespace Exercises.Exercise2
{
    [TestFixture]
    public sealed class CalculatorSumTests
    {
        [Test]
        public void ItShouldSumTwoNumbers()
        {
            // Arrange
            const decimal firstNumber = 12.3m;
            const decimal secondNumber = 10.3m;
            const decimal expectedResult = 22.6m;
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(firstNumber, secondNumber);


            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
