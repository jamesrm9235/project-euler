using NUnit.Framework;
using System;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem20Test
    {
        [Test]
        public void Factorial_ThrowsArgumentException_WhenInputIsLessThan0()
        {
            // Arrange
            var input = -1;
        
            // Act & Assert
            Assert.Throws(typeof(ArgumentException), () => Problem20.Factorial(input));
        }

        [TestCase(0)]
        [TestCase(1)]
        public void Factorial_Returns1_WhenInputIs0Or1(int n)
        {
            // Arrange
            var input = n;
        
            // Act
            var result = Problem20.Factorial(input);
        
            // Assert
            Assert.AreEqual(new BigInteger(1), result);
        }

        [Test]
        public void Factorial_Returns3628800_WhenInputIs10()
        {
            // Arrange
            var input = 10;
        
            // Act
            var result = Problem20.Factorial(input);
        
            // Assert
            Assert.AreEqual(new BigInteger(3628800), result);
        }

        [Test]
        public void Solve_Returns27_WhenInputIs10()
        {
            // Arrange
            var input = 10;
        
            // Act
            var solution = Problem20.Solve(input);
        
            // Assert
            Assert.AreEqual(27, solution);
        }
    }
}