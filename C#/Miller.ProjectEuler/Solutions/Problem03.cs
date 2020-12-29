using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Largest prime factor
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=3"/>
    public class Problem03
    {
        /// <summary>
        /// Finds the largest prime factor of <paramref name="number"/> by reverse iteration.
        /// 2 insights are applied to optimize performance:
        /// <para>
        /// The limit is set to the square root of <paramref name="number"/> because the largest factor cannot be greater than the square root of <paramref name="number"/>.
        /// </para>
        /// <para>
        /// The loop iterates in reverse because the largest prime factor should be at the end of the sequence.
        /// </para>
        /// </summary>
        /// <param name="number">Default is 600,851,475,143.</param>
        /// <returns>Largest prime factor.</returns>
        /// <exception cref="Exception">Thrown when no prime factors are found for <paramref name="number"/>.</exception>
        public ulong Solve(ulong number = 600_851_475_143)
        {
            ulong limit = (ulong)Math.Ceiling(Math.Sqrt(number)); //

            for (ulong i = limit; i > 0; i--) // iterate in reverse order since the problem asked for the largest prime
            {
                if (number % i == 0 && i.IsPrime())
                {
                    return i;
                }
            }
            throw new Exception($"No prime factors were found for {number}.");
        }
    }
}
