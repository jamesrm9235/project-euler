using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem06Test
    {
        [TestCase(10, ExpectedResult = 2640)]
        [TestCase(100, ExpectedResult = 25164150)]
        public double Test_Solution(int x)
        {
            var sut = new Problem06();

            var actual = sut.Solve(limit: x);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
