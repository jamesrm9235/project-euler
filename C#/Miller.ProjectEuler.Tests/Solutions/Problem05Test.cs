using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem05Test
    {
        [TestCase((ulong)10, ExpectedResult = 2520)]
        [TestCase((ulong)20, ExpectedResult = 232_792_560)]
        public ulong Test_Solution(ulong x)
        {
            var sut = new Problem05();

            var actual = sut.Solve(limit: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
