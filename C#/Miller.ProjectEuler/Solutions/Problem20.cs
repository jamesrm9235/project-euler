using System;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Factorial digit sum
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=20"/>
    public class Problem20
    {
        /// <summary>
        /// Finds the sum of the digits in the factorial of <paramref name="n"/>.
        /// </summary>
        /// <param name="n">The number whose factorial will be found. Default is 100.</param>
        /// <returns>
        /// The sum of the digits of the result of <paramref name="n"/> factorial.
        /// </returns>
        public int Solve(int n = 100)
        {
            var result = Factorial(n).ToString();

            var sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                sum += int.Parse(result[i].ToString());
            }
            return sum;
        }

        /// <summary>
        /// Finds the product of all positive integers less than or equal to <paramref name="n"/>.
        /// </summary>
        /// <param name="n">The number whose factorial will be found.</param>
        /// <returns>
        /// The factorial of <paramref name="n"/>.
        /// </returns>
        public BigInteger Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} must be a positive integer.");
            }

            if (n == 0 | n == 1)
            {
                return 1;
            }

            var product = new BigInteger(n);
            for (int i = n - 1; i != 1; i--)
            {
                product *= i;
            }

            return product;
        }
    }
}