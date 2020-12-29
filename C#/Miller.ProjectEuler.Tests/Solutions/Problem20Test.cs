using NUnit.Framework;
using System;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem20Test
    {
        [TestCase(10, ExpectedResult = 27)]
        [TestCase(100, ExpectedResult = 648)]
        public int Test_Solution(int x)
        {
            var sut = new Problem20();

            var actual = sut.Solve(n: x);

            TestContext.WriteLine(actual);
            return actual;
        }

        [Test]
        public void Factorial_ThrowsArgumentException_WhenInputIsLessThan0()
        {
            var input = -1;
            var sut = new Problem20();

            Assert.Throws(typeof(ArgumentException), () => sut.Factorial(input));
        }

        [TestCase(0)]
        [TestCase(1)]
        public void Factorial_Returns1_WhenInputIs0Or1(int n)
        {
            var sut = new Problem20();

            var actual = sut.Factorial(n);

            Assert.AreEqual(new BigInteger(1), actual);
        }

        [Test]
        public void Factorial_Returns3628800_WhenInputIs10()
        {
            var input = 10;
            var sut = new Problem20();

            var actual = sut.Factorial(input);

            Assert.AreEqual(new BigInteger(3628800), actual);
        }
    }
}
