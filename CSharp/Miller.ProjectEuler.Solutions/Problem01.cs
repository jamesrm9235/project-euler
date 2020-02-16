using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public sealed class Problem01 : IProblem
    {
        public string Name => "Multiples of 3 and 5";

        private int _count;
        public Problem01(int count)
        {
            _count = count;
        }

        /// <summary>
        /// Uses a loop to compute the sum of all the multiples of 3 or 5 less than the count.
        /// </summary>
        /// <returns>The computed sum</returns>
        public string Solve()
        {
            var result = 0;
            for (int i = 1; i < _count; i++)
            {
                if (IsMultipleOf(i, 3) || IsMultipleOf(i, 5))
                {
                    result += i;
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Checks whether x is evenly divisible by y.
        /// </summary>
        /// <param name="x">The integer to divide. Cannot be zero.</param>
        /// <param name="y">The integer to divide x by. Cannot be zero.</param>
        /// <returns>True if x is a multiple of y and false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if either parameter is zero.</exception>
        private bool IsMultipleOf(int x, int y)
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
