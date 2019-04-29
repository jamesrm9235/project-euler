using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    public class Problem4Test
    {
        [TestCase("racecar")]
        [TestCase("rotator")]
        public void IsPalindrome_ReturnsTrue_WhenStringIsPalindromic(string str)
        {
            // Arrange
            var input = str;

            // Act
            var result = Problem4.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase("hello")]
        [TestCase("world")]
        public void IsPalindrome_ReturnsFalse_WhenStringIsNotPalindromic(string str)
        {
            // Arrange
            var input = str;

            // Act
            var result = Problem4.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void SolveExample_Returns9009_WhenFindingLargestPalindromeFromProductOf2DigitNumbers()
        {
            // Arrange

            // Act
            var result = Problem4.SolveForProductOfTwoDigitNumbers();

            // Assert
            Assert.AreEqual(9009, result);
        }

        [Test]
        public void Solve_Returns906609_WhenFindingLargestPalindromeFromProductOf2ThreeDigitNumbers()
        {
            // Arrange
        
            // Act
            var result = Problem4.Solve();
        
            // Assert
            Assert.AreEqual(906609, result);
        }
    }
}