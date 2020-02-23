using Miller.ProjectEuler.Solutions.Extensions;
using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=3
    /// </summary>
    public sealed class Problem03 : IProblem
    {
        public string Name => "Largest prime factor";

        private ulong _number;

        public Problem03(ulong number = 600_851_475_143)
        {
            _number = number;
        }

        /// <summary>
        /// Solves problem 3 by testing each factor of the passed in number for primality
        /// and returns the largest one found. The numbers are tested in reverse
        /// order beginning with the square root of the passed in number.
        /// </summary>
        /// <returns>Largest prime factor</returns>
        public string Solve()
        {
            ulong limit = (ulong)Math.Ceiling(Math.Sqrt(_number));
            for (ulong i = limit; i > 0; i--)
            {
                if (_number % i == 0 && i.IsPrime())
                {
                    return i.ToString();
                }
            }
            throw new Exception($"No primes were found for number {_number}.");
        }
    }
}