namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=2
    /// </summary>
    public sealed class Problem02 : IProblem
    {
        public string Name => "Even Fibonacci numbers";

        private int _limit;

        public Problem02(int limit = 4_000_000)
        {
            _limit = limit;
        }

        /// <summary>
        /// Solves problem 2 by generating terms in the Fibonacci series up to the limit,
        /// and if a term is even, it is added to a running sum.
        /// </summary>
        /// <returns>Sum of all even terms in the Fibonacci series</returns>
        public string Solve()
        {
            int result = 0;
            int previousTerm = 1, leadingTerm = 2, intermediateTerm;
            while (leadingTerm < _limit)
            {
                if (leadingTerm % 2 == 0)
                {
                    result += leadingTerm;
                }
                intermediateTerm = leadingTerm;
                leadingTerm += previousTerm;
                previousTerm = intermediateTerm;
            }

            return result.ToString();
        }
    }
}