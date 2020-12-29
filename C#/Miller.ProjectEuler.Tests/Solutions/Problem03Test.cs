using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem03Test
    {
        [TestCase((ulong)13195, ExpectedResult = 29)]
        [TestCase((ulong)600_851_475_143, ExpectedResult = 6857)]
        public ulong Test_Solution(ulong x)
        {
            var sut = new Problem03();

            var actual = sut.Solve(number: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
