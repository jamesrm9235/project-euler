namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// 10001st prime
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=7"/>
    public class Problem07
    {
        /// <summary>
        /// Uses trial division to count a number of primes equal to the count.
        /// </summary>
        /// <param name="count">The number of primes to count.</param>
        /// <returns>The last prime that was counted.</returns>
        public ulong Solve(int count = 10001)
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

            int primesCounted = 2; // Include 2 and 3 in count

            do
            {
                n += 2; // only test odd number
                if (n.IsPrime())
                {
                    primesCounted += 1;
                }
            } while (primesCounted < count);

            return n;
        }
    }
}
