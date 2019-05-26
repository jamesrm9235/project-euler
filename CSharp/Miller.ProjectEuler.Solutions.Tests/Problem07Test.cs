using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture, Description("https://projecteuler.net/problem=7")]
    public class Problem07Test
    {
        [Test]
        public void Solve_Returns13_WhenCountingUpTo6thPrime()
        {
            // Arrange
            ulong expected = 13;
            int count = 6;
        
            // Act
            var actual = Problem07.Solve(count);
        
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_Returns104743_WhenCountingUpTo10001stPrime()
        {
            // Arrange
            ulong expected = 104743;
        
            // Act
            var actual = Problem07.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}