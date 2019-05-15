using System;

namespace Miller.ProjectEuler.Solutions.Extensions
{
    public static class UnsignedLongExtensions
    {
        /// <summary>
        /// Checks whether the number is a prime by trial division.
        /// </summary>
        /// <param name="number">The number to check for primality.</param>
        /// <returns>True if the number is prime otherwise false.</returns>
        public static bool IsPrime(this ulong number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2 || number == 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            ulong divisor = 5;
            ulong limit = (ulong)Math.Ceiling(Math.Sqrt(number));
            while (divisor <= limit)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
                divisor += 2;
                if (number % divisor == 0)
                {
                    return false;
                }
                divisor += 4;
            }
            return true;
        }
    }
}