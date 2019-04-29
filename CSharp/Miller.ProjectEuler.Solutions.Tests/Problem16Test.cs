using System.Collections.Generic;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    public class Problem16Test
    {
        [Test]
        public void Solve_Returns26_WhenXIs2AndYIs15()
        {
            // Arrange
            var x = 2;
            var y = 15;

            // Act
            var result = Problem16.Solve(x, y);

            // Assert
            Assert.AreEqual(26, result);
        }

        [Test]
        [Explicit]
        public void Solve_Returns1366_WhenXIs2AndYIs1000()
        {
            // Arrange
            var x = 2;
            var y = 1000;

            // Act
            var result = Problem16.Solve(x, y);

            // Assert
            Assert.AreEqual(1366, result);
        }
    }
}