using System;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=20
    /// </summary>
    public static class Problem20
    {
        /// <summary>
        /// Finds the sum of the digits in the factorial of n.
        /// </summary>
        /// <param name="n">The number whose factorial will be found.</param>
        /// <returns>The sum of the digits of the result of n factorial.</returns>
        public static int Solve(int n)
        {
            var result = Factorial(n).ToString();
            var sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += Int32.Parse(result[i].ToString());
            }
            return sum;
        }

        /// <summary>
        /// Finds the product of all positive integers less than or equal to n.
        /// </summary>
        /// <param name="n">The number whose factorial will be found.</param>
        /// <returns>The factorial of n.</returns>
        public static BigInteger Factorial(int n)
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

        // public static int Factorial(int n)
        // {
        //     if (n == 1)
        //     {
        //         return 1;
        //     }
        //     return n * Factorial(n--);
        // }
    }
}