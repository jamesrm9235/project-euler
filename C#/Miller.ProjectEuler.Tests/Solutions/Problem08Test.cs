using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem08Test
    {
        [TestCase(4, ExpectedResult = 5_832)]
        [TestCase(13, ExpectedResult = 23_514_624_000)]
        public ulong Test_Solution(int x)
        {
            var sut = new Problem08();

            var actual = sut.Solve(length: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
