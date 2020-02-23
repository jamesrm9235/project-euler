using System.IO;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem22Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem22Sample()
        {
            // Arrange
            string input = "\"COLIN\"";
            string expected = "53";
            IProblem sut = new Problem22(input);

            // Act
            string actual = sut.Solve();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Explicit]
        [Test]
        public void Solve_ReturnsSolution_ForProblem22()
        {
            using (StreamReader reader = new StreamReader("../../../../../resources/p022_names.txt"))
            {
                // Arrange
                var expected = "871198282";
                var input = reader.ReadToEnd();
                IProblem sut = new Problem22(input);

                // Act
                var actual = sut.Solve();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}