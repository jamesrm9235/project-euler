using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture, Description("https://projecteuler.net/problem=2")]
    public class Problem02Test
    {
        [Test]
        public void FibonacciSeries_Returns4613732_WhenMaxTermIsFourMillion()
        {
            // Arrange
            var expected = 4613732;
            var maxTerm = 4000000;
        
            // Act
            var actual = Problem02.Solve(maxTerm);
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}