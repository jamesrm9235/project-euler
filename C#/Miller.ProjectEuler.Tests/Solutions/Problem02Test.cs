using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem02Test
    {
        [TestCase(4_000_000, ExpectedResult = 4613732)]
        public int Test_Solution(int x)
        {
            var sut = new Problem02();

            var actual = sut.Solve(limit: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
