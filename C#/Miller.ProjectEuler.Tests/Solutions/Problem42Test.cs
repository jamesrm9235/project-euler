using NUnit.Framework;
using System.IO;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem42Test
    {
        [Test]
        public void Test_Solution_WithSample()
        {
            var input = "SKY";
            var sut = new Problem42();

            var actual = sut.Solve(input);

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Test_Solution_WithFile()
        {
            var words = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Data", "p042_words.txt"));
            var sut = new Problem42();

            var actual = sut.Solve(words);

            Assert.AreEqual(162, actual);
        }
    }
}
