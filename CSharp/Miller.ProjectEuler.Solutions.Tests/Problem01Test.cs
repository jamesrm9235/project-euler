using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    [TestFixture, Description("https://projecteuler.net/problem=1")]
    public class Problem01Test
    {
        [Test]
        public void IsMultipleOf_ReturnsTrue_WhenXIsAMultipleOf3LessThan10(
            [Values(3, 6, 9)] int x,
            [Values(3)] int y)
        {
            // Arrange.

            // Act
            var actual = Problem01.IsMultipleOf(x, y);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsMultipleOf_ReturnsTrue_WhenXIsAMultipleOf5LessThan10(
            [Values(5)] int x,
            [Values(5)] int y)
        {
            // Arrange.

            // Act
            var actual = Problem01.IsMultipleOf(x, y);

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void IsMultipleOf_ReturnsFalse_WhenXIsNotAMultipleOf3LessThan10(
            [Values(1, 2, 4, 5, 7, 8)] int x,
            [Values(3)] int y)
        {
            // Arrange.

            // Act
            var actual = Problem01.IsMultipleOf(x, y);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void IsMultipleOf_ReturnsFalse_WhenXIsNotAMultipleOf5LessThan10(
            [Values(1, 2, 3, 4, 6, 7, 8, 9)] int x,
            [Values(5)] int y)
        {
            // Arrange.

            // Act
            var actual = Problem01.IsMultipleOf(x, y);

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void SolveWithLoop_Returns23_WhenCountIs10()
        {
            // Arrange
            var count = 10;

            // Act
            var actual = Problem01.SolveWithLoop(count);

            // Assert
            Assert.AreEqual(23, actual);
        }

        [Test]
        public void SolveWithLinq_Returns23_WhenCountIs10()
        {
            // Arrange
            var count = 10;
        
            // Act
            var actual = Problem01.SolveWithLinq(count);
        
            // Assert
            Assert.AreEqual(23, actual);
        }

        [Test]
        public void SolveWithLoop_Returns233168_WhenCountIs1000()
        {
            // Arrange
            var count = 1000;
        
            // Act
            var actual = Problem01.SolveWithLoop(count);
        
            // Assert
            Assert.AreEqual(233168, actual);
        }

        [Test]
        public void SolveWithLinq_Returns233168_WhenCountIs1000()
        {
            // Arrange
            var count = 1000;
        
            // Act
            var actual = Problem01.SolveWithLinq(count);
        
            // Assert
            Assert.AreEqual(233168, actual);
        }
    }
}