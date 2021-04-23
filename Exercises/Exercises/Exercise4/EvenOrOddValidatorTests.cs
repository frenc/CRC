using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Exercises.Exercise4
{
    [TestFixture]
    public sealed class EvenOrOddValidatorTests
    {
        [TestCaseSource(nameof(GetTestData))]
        public void ShouldReturnOddOrEventArraySumValues(List<int> values, OddInformation oddInformation)
        {
            
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] {new List<int> {1, 2, 4, 11}, OddInformation.Eve};
        }
    }
}
