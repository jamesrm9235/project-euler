using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem04Test
    {
        [Test]
        public void Test_Solution()
        {
            var sut = new Problem04();

            var actual = sut.Solve();

            Assert.AreEqual(906609, actual);
        }
    }
}
