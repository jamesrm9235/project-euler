using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    public class Problem05Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem05Sample()
        {
            // Arrange
            var expected = "2520";
            IProblem sut = new Problem05(limit: 10);
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_ReturnsSolution_ForProblem05()
        {
            // Arrange
            var expected = "232792560";
            IProblem sut = new Problem05();
            
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}