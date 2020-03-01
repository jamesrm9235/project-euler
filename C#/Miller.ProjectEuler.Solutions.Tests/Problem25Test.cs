using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem25Test
    {
        [Test]
        public void Solve_Returns4782_WhenDigitLengthIs1000()
        {
            // Arrange
            var digitLength = 1000;

            // Act
            var result = Problem25.Solve(digitLength);

            // Assert
            Assert.AreEqual(4782, result);
        }
    }
}