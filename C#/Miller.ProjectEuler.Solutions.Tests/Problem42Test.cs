using System.IO;
using System.Reflection;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem42Test
    {
        [Test]
        public void Solve_ReturnsSolution_ForProblem42Sample()
        {
            // Arrange
            var expected = "1";
            var input = "SKY";
            IProblem sut = new Problem42(input);

            // Act
            var actual = sut.Solve();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Explicit]
        [Test]
        public void Solve_ReturnsSolution_ForProblem42()
        {
            Stream res = Assembly.GetExecutingAssembly().GetManifestResourceStream($"{typeof(Problem42Test).Namespace}.Resources.p042_words.txt");
            using (StreamReader reader = new StreamReader(res))
            {
                // Arrange
                var expected = "162";
                IProblem sut = new Problem42(reader.ReadToEnd());

                // Act
                var actual = sut.Solve();

                // Assert
                Assert.AreEqual(expected, actual);
            }

        }
    }
}