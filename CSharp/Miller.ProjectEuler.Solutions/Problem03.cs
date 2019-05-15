using System;
using Miller.ProjectEuler.Solutions.Extensions;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=3
    /// </summary>
    public static class Problem03
    {
        /// <summary>
        /// Solves problem 3 by testing each factor of the passed in number for primality
        /// and returns the largest one when found. The numbers are tested in reverse
        /// order beginning with the square root of the passed in number.
        /// </summary>
        /// <param name="number">The number whose largest prime factor to find.</param>
        /// <returns>The largest prime factor of the number.</returns>
        public static ulong Solve(ulong number = 600851475143)
        {
            ulong limit = (ulong)Math.Ceiling(Math.Sqrt(number));
            for (ulong i = limit; i > 0; i--)
            {
                if (number % i == 0 && i.IsPrime())
                {
                    return i;
                }
            }
            throw new Exception($"No primes were found for number {number}.");
        }
    }
}