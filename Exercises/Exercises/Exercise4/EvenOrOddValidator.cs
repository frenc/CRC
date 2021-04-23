using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Exercise4
{
    public sealed class EvenOrOddValidator
    {
        public OddInformation Validate(List<int> values)
        {
            return values.Sum() % 2 == 0 ? OddInformation.Eve : OddInformation.Odd;
        }
    }
}
