using Miller.ProjectEuler.Solutions.Utils;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=7
    /// </summary>
    public static class Problem07
    {
        /// <summary>
        /// Uses trial division to count a number of primes equal to the count.
        /// </summary>
        /// <param name="count">The number of primes to count.</param>
        /// <returns>The last prime that was counted.</returns>
        public static ulong Solve(int count = 10001)
        {
            if (count <= 0)
            {
                return 0;
            }
            else if (count == 1)
            {
                return 2;
            }
            else if (count == 2)
            {
                return 3;
            }

            ulong n = 3;

            // Include 2 and 3 in count.
            int primesCounted = 2;

            do
            {
                // Only test odd numbers.
                n += 2;
                if (n.IsPrime())
                {
                    primesCounted += 1;
                }
            } while (primesCounted < count);
            return n;
        }
    }
}