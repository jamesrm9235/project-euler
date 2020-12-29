namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Even Fibonacci numbers
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=2"/>
    public class Problem02
    {
        /// <summary>
        /// Generates every term in the Fibonacci sequence up to <paramref name="limit"/>.
        /// If the term is even, it is added to a sum.
        /// </summary>
        /// <param name="limit">Default is 4,000,000.</param>
        /// <returns>
        /// Sum of all even terms in the Fibonacci series.
        /// </returns>
        public int Solve(int limit = 4_000_000)
        {
            int sum = 0;

            int previous = 1, leading = 2, intermediate;

            while (leading < limit)
            {
                if (leading % 2 == 0)
                {
                    sum += leading;
                }
                intermediate = leading;
                leading += previous;
                previous = intermediate;
            }

            return sum;
        }
    }
}