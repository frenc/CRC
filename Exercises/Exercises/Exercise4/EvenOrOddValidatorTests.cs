﻿using System;
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
            var result = new EvenOrOddValidator().Validate(values);
            
            Assert.That(result, Is.EqualTo(oddInformation));
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] {new List<int> {1, 2, 4, 11}, OddInformation.Even};
            yield return new object[] {new List<int> { 0, -2, 4, 3211 }, OddInformation.Odd};
            yield return new object[] {new List<int> { -4, -5, -6, -7 }, OddInformation.Even};
        }
    }
}
