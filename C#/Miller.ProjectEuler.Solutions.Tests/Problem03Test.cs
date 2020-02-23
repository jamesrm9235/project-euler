using Miller.ProjectEuler.Solutions;
using NUnit.Framework;

namespace TesMiller.ProjectEuler.Solutions.Teststs
{
    [TestFixture]
    public class Problem03Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem03Sample()
        {
            // Arrange
            var expected = "29";
            ulong number = 13195;
            var sut = new Problem03(number);
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_ReturnsSolution_ForProblem03()
        {
            // Arrange
            var expected = "6857";
            var sut = new Problem03();
        
            // Act
            var actual = sut.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}