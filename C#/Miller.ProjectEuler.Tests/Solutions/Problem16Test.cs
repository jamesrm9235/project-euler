using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem16Test
    {
        [TestCase(2, 15, ExpectedResult = 26)]
        [TestCase(2, 1000, ExpectedResult = 1366)]
        public int Test_Solution(int x, int y)
        {
            var sut = new Problem16();

            var actual = sut.Solve(x, y);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
