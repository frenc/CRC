using System;

namespace Exercises.Exercise2
{
    public sealed class Calculator
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }

            return firstNumber / secondNumber;
        }
    }
}