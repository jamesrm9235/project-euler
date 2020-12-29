namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Multiples of 3 and 5
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=1"/>
    public class Problem01
    {
        /// <summary>
        /// Iterates through every number in sequence up to <paramref name="limit"/> and adds the number to a sum if it is a multiple of 3 or 5.
        /// </summary>
        /// <param name="limit">Default is 1000.</param>
        /// <returns>
        /// Calculated sum.
        /// </returns>
        public int Solve(int limit=1000)
        {
            var sum = 0;

            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
