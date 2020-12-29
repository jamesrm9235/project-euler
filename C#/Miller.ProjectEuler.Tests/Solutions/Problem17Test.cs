using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem17Test
    {
        [TestCase(5, ExpectedResult = 19)]
        [TestCase(1000, ExpectedResult = 21124)]
        public int Test_Solution(int x)
        {
            var sut = new Problem17();

            var actual = sut.Solve(limit: x);

            TestContext.Write(actual);
            return actual;
        }

        [TestCase(100, ExpectedResult = "one hundred")]
        [TestCase(342, ExpectedResult = "three hundred and forty two")]
        public string NumberAsWords_ReturnsNumberExpressedAsWord(int n)
        {
            var sut = new Problem17();

            var actual = sut.NumberAsWords(n);

            TestContext.WriteLine(actual);
            return actual;
        }
    }
}
