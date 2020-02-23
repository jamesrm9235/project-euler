using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem04Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem04()
        {
            // Arrange
            var expected = "906609";
            var sut = new Problem04();
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}