using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem07Test
    {
        [TestCase(6, ExpectedResult = 13)]
        [TestCase(10001, ExpectedResult = 104743)]
        public ulong Test_Solution(int x)
        {
            var sut = new Problem07();

            var actual = sut.Solve(count: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
