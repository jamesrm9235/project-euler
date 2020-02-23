using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem01Test
    {
        [Test]
        public void Solve_Returns23_ForProblem01Sample()
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
        public void Solve_ReturnsSolution_ForProblem01()
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