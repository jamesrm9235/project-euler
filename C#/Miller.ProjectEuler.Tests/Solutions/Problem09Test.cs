using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions
{
    [TestFixture]
    public class Problem09Test
    {
        [Test]
        public void Test_Solution()
        {
            var sut = new Problem09();

            var actual = sut.Solve();

            Assert.AreEqual(31875000, actual);
        }
    }
}
