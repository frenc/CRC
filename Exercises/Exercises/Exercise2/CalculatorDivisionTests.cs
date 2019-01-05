using System;
using NUnit.Framework;

namespace Exercises.Exercise2
{
    [TestFixture]
    public sealed class CalculatorDivisionTests
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase(1, 2, 0.5)]
        [TestCase(10, 10, 1)]
        [TestCase(100, 10, 10)]
        public void ItShouldDivideTwoNumbers(decimal firstNumber, decimal secondNumber, decimal expectedResult)
        {
            // Arrange

            // Act
            var result = _calculator.Divide(firstNumber, secondNumber);


            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ItShouldThrowExceptionWhenDivideByZero()
        {
            // Arrange
            const decimal firstNumber = 12.3m;
            const decimal secondNumber = 0m;

            // Act
            void Execute()
            {
                _calculator.Divide(firstNumber, secondNumber);
            }

            // Assert
            Assert.That(Execute, Throws.InstanceOf<DivideByZeroException>());
        }
    }
}
