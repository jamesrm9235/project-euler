using System;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture]
    public class Problem17Test
    {
        [TestCase("three hundred and forty-two", ExpectedResult = "threehundredandfortytwo")]
        [TestCase("one hundred and fifteen", ExpectedResult = "onehundredandfifteen")]
        public string Sanitize_ReturnsStringWithoutSpacesAndHyphens_WhenStringContainsSpacesOrHyphens(string str)
        {
            // Arrange
            var input = str;

            // Act
            var actual = Problem17.Sanitize(input);

            // Assert
            return actual;
        }

        [TestCase("three hundred and forty-two", ExpectedResult = 23)]
        [TestCase("one hundred and fifteen", ExpectedResult = 20)]
        public int SanitizedString_ReturnsCountOfLetters_WhenStringContainsSpacesOrHyphens(string str)
        {
            // Arrange
            var input = str;

            // Act
            var actual = Problem17.Sanitize(input);

            // Assert
            return actual.Length;
        }

        [Test]
        public void MakeStringOfSanitizedNumbersAsWords_ThrowsArgumentException_WhenIntegerLessThan1IsPassed()
        {
            // Arrange
            var countUpTo = 0;
        
            // Act & Assert
            Assert.Throws(typeof(ArgumentException), () => Problem17.MakeStringOfSanitizedNumbersAsWords(countUpTo));
        }

        [Test]
        [Description("Validates the example in the problem description.")]
        public void MakeStringOfSanitizedNumbersAsWords_Returns19Letters_WhenCountingUpTo5()
        {
            // Arrange
            var countUpTo = 5;

            // Act
            var actual = Problem17.MakeStringOfSanitizedNumbersAsWords(countUpTo);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual("onetwothreefourfive", actual);
                Assert.AreEqual(19, actual.Length);
            });
        }

        [Test]
        public void ConvertNumberToWord_ReturnsNumberAsWord_WhenNumberIsGreaterThanTwenty(
            [Values(20)] int tens,
            [Values(1, 2, 3, 4, 5, 6, 7, 8, 9)] int units,
            [Values("twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine")] string expected
        )
        {
            // Arrange
            var number = tens + units;
        
            // Act
            var actual = Problem17.ConvertNumberToWord(number);
        
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, ExpectedResult="one hundred")]
        [TestCase(342, ExpectedResult="three hundred and forty two")]
        public string ConvertNumberToWord_ReturnsNumberAsWorld_WhenNumberIsGreaterThanOneHundred(int n)
        {
            // Arrange

            // Act
            var actual = Problem17.ConvertNumberToWord(n);
        
            // Assert
            return actual;
        }
    }
}