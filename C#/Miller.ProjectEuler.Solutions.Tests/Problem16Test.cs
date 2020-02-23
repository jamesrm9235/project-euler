using System.Collections.Generic;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem16Test
    {
        [TestCase(2, 15, ExpectedResult=26)]
        [TestCase(2, 1000, ExpectedResult=1366)]
        public int Solve_ReturnsExpectedSum_ForSumOfDigitsOfExponentiationResultOfXAndY(int x, int y)
        {
            // Arrange

            // Act
            var result = Problem16.Solve(x, y);

            // Assert
            return result;
        }
    }
}