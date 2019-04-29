using NUnit.Framework;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions.Tests
{
    public class Problem20Test
    {
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

        [Test]
        [Explicit]
        public void Factorial_Returns_WhenInputIs100()
        {
            // Arrange
            var input = 100;
        
            // Act
            var result = Problem20.Factorial(input);
        
            // Assert
        
        }
    }
}