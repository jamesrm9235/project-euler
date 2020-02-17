using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem02Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem02()
        {
            // Arrange
            var expected = "4613732";
            var sut = new Problem02();
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}