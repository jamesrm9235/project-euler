using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem04Test
    {
        [TestCase("racecar")]
        [TestCase("rotator")]
        public void IsPalindrome_ReturnsTrue_WhenStringIsPalindrome(string str)
        {
            // Arrange
            var input = str;

            // Act
            var result = Problem04.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase("hello")]
        [TestCase("world")]
        public void IsPalindrome_ReturnsFalse_WhenStringIsNotPalindrome(string str)
        {
            // Arrange
            var input = str;

            // Act
            var result = Problem04.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void SolveExample_Returns9009_WhenFindingLargestPalindromeFromProductOfTwo2DigitNumbers()
        {
            // Arrange
            var expected = 9009;

            // Act
            var actual = Problem04.SolveForProductOfTwoDigitNumbers();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solve_Returns906609_WhenFindingLargestPalindromeFromProductOfTwo3DigitNumbers()
        {
            // Arrange
            var expected = 906609;
        
            // Act
            var actual = Problem04.Solve();
        
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}