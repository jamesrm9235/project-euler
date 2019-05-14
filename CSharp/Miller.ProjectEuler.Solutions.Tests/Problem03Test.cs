using Miller.ProjectEuler.Solutions;
using NUnit.Framework;

namespace TesMiller.ProjectEuler.Solutions.Teststs
{
    [TestFixture, Description("https://projecteuler.net/problem=3")]
    public class Problem03Test
    {
        [Test]
        public void Solve_Returns29_WhenSolvingExample()
        {
            // Arrange
            ulong expected = 29;
            ulong number = 13195;
        
            // Act
            var actual = Problem03.Solve(number);
        
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_Returns6857_WhenSolvingProblem()
        {
            // Arrange
            ulong expected = 6857;
        
            // Act
            var actual = Problem03.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}