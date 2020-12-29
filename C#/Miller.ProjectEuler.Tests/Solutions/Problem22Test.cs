using NUnit.Framework;
using System.IO;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem22Test
    {
        [Test]
        public void Test_Solution_WithSample()
        {
            string input = "\"COLIN\"";
            var sut = new Problem22();

            var actual = sut.Solve(input);

            Assert.AreEqual(53, actual);
        }

        [Test]
        public void Test_Solution_WithFile()
        {
            var names = File.ReadAllText(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "Data",
                "p022_names.txt"));
            var sut = new Problem22();

            var actual = sut.Solve(names);

            Assert.AreEqual(871198282, actual);
        }
    }
}
