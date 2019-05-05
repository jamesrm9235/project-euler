using System;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public static class Problem01
    {
        /// <summary>
        /// Uses Linq to compute the sum of all the multiples of 3 or 5 less than the count.
        /// </summary>
        /// <param name="count">The number of integers to count. Must be a natural number greater than zero.</param>
        /// <returns>The computed sum.</returns>
        /// <exception cref="ArgumentException">Thrown if count is less than or equal to zero.</exception>
        public static int SolveWithLinq(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException($"{nameof(count)} must be a natural number greater than zero.");
            }

            var multiples = Enumerable
            .Range(1, count - 1)
            .Where(x => IsMultipleOf(x, 3) || IsMultipleOf(x, 5));
            return multiples.Sum();
        }

        /// <summary>
        /// Uses a loop to compute the sum of all the multiples of 3 or 5 less than the count.
        /// </summary>
        /// <param name="count">The number of integers to count. Must be a natural number greater than zero.</param>
        /// <returns>The computed sum.</returns>
        /// <exception cref="ArgumentException">Thrown if count is less than or equal to zero.</exception>
        public static int SolveWithLoop(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException($"{nameof(count)} must be a natural number greater than zero.");
            }

            var result = 0;
            for (int i = 1; i < count; i++)
            {
                if (IsMultipleOf(i, 3) || IsMultipleOf(i, 5))
                {
                    result += i;
                }
            }
            return result;
        }

        /// <summary>
        /// Checks whether x is evenly divisible by y.
        /// </summary>
        /// <param name="x">The integer to divide. Cannot be zero.</param>
        /// <param name="y">The integer to divide x by. Cannot be zero.</param>
        /// <returns>True if x is a multiple of y and false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if either parameter is zero.</exception>
        public static bool IsMultipleOf(int x, int y)
        {
            if (x == 0)
            {
                throw new ArgumentException($"{nameof(x)} cannot be zero.");
            }
            if (y == 0)
            {
                throw new ArgumentException($"{nameof(y)} cannot be zero.");
            }
            return x % y == 0;
        }
    }
}
