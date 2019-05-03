using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public static class Problem01
    {
        /// <summary>
        /// Uses a loop to calculate the sum of all the multiples of 3 or 5 less than the count.
        /// </summary>
        /// <param name="count">The number of integers to count.</param>
        /// <returns>The sum.</returns>
        public static int SolveWithLoop(int count)
        {
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
        /// Uses Linq to calculate the sum of all the multiples of 3 or 5 less than the count.
        /// </summary>
        /// <param name="count">The number of integers to count.</param>
        /// <returns>The sum.</returns>
        public static int SolveWithLinq(int count)
        {
            var multiples = Enumerable
            .Range(1, count - 1)
            .Where(x => IsMultipleOf(x, 3) || IsMultipleOf(x, 5));
            return multiples.Sum();
        }

        /// <summary>
        /// Checks whether x is evenly divisible by y.
        /// </summary>
        /// <param name="x">The integer to divide.</param>
        /// <param name="y">The integer to divide x by.</param>
        /// <returns>True if x is a multiple of y and false otherwise.</returns>
        public static bool IsMultipleOf(int x, int y)
        {
            return x % y == 0;
        }
    }
}
