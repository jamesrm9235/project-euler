using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem28Test
    {
        [TestCase(5, ExpectedResult = 101)]
        [TestCase(1001, ExpectedResult = 669_171_001)]
        public int Test_Solution(int size)
        {
            var sut = new Problem28();

            var actual = sut.Solve(size);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
