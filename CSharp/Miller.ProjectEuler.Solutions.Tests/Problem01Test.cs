using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [Description("https://projecteuler.net/problem=1")]
    [TestFixture]
    public class Problem01Test
    {
        [Test]
        public void Solve_Returns23_WhenCountIs10()
        {
            // Arrange
            int count = 10;
            string expected = "23";
            IProblem sut = new Problem01(count);

            // Act
            var actual = sut.Solve();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_Returns233168_WhenCountIs1000()
        {
            // Arrange
            int count = 1000;
            string expected = "233168";
            IProblem sut = new Problem01(count);

            // Act
            string actual = sut.Solve();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}