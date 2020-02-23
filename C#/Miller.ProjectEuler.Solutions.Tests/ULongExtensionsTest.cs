using Miller.ProjectEuler.Solutions.Utils;
using NUnit.Framework;

namespace Miller.ProjectEuler.Solutions.Tests
{
    public class UnsignedLongExtensionsTest
    {
        [TestCase((ulong)2)]
        [TestCase((ulong)3)]
        [TestCase((ulong)5)]
        [TestCase((ulong)7)]
        [TestCase((ulong)11)]
        [TestCase((ulong)13)]
        [TestCase((ulong)17)]
        [TestCase((ulong)19)]
        public void IsPrime_ReturnsTrue_ForKnownPrimesLessThan20(ulong prime)
        {
            // Arrange
        
            // Act
            var actual = prime.IsPrime();
        
            // Assert
            Assert.IsTrue(actual);
        }

        [TestCase((ulong)1)]
        [TestCase((ulong)4)]
        [TestCase((ulong)6)]
        [TestCase((ulong)8)]
        [TestCase((ulong)9)]
        [TestCase((ulong)10)]
        public void IsPrime_ReturnsFalse_ForNonPrimesLessThan10(ulong nonPrime)
        {
            // Arrange
        
            // Act
            var actual = nonPrime.IsPrime();
        
            // Assert
            Assert.IsFalse(actual);
        }
    }
}