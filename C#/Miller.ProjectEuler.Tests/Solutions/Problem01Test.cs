using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem01Test
    {
        [TestCase(10, ExpectedResult = 23)]
        [TestCase(1000, ExpectedResult = 233168)]
        public int Test_Solution(int x)
        {
            var sut = new Problem01();

            var actual = sut.Solve(limit: x);

            TestContext.Write(actual);
            return actual;
        }
    }
}
