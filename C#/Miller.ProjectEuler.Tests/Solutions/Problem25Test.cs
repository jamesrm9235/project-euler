using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem25Test
    {
        [TestCase(3, ExpectedResult = 12)]
        [TestCase(1000, ExpectedResult = 4782)]
        public int Test_Solution(int x)
        {
            var sut = new Problem25();

            var actual = sut.Solve(length: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
