using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem09Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem09()
        {
            // Arrange
            var expected = "31875000";
            IProblem sut = new Problem09();

            // Act
            var actual = sut.Solve();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}