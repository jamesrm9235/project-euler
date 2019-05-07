namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=2
    /// </summary>
    public static class Problem02
    {
        /// <summary>
        /// Solves problem 2 by generating terms in the Fibonacci series up to the max term,
        /// and if a term is even, it is added to a running sum of even terms.
        /// </summary>
        /// <param name="maxTerm">The term that the greatest term in the Fibonacci series must not exceed.</param>
        /// <returns>The sum of all even terms in the Fibonacci series.</returns>
        public static int Solve(int maxTerm)
        {
            var result = 0;

            var previousTerm = 1;
            var leadingTerm = 2;
            int intermediateTerm;
            while (leadingTerm < maxTerm)
            {
                if (leadingTerm % 2 == 0)
                {
                    result += leadingTerm;
                }
                intermediateTerm = leadingTerm;
                leadingTerm += previousTerm;
                previousTerm = intermediateTerm;
            }

            return result;
        }
    }
}