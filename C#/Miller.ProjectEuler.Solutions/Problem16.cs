using System;
using System.Collections.Generic;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=16
    /// </summary>
    public static class Problem16
    {
        /// <summary>
        /// Calculates the sum of the digits of the exponentiation result of x to the power of y.
        /// </summary>
        /// <param name="x">The base integer.</param>
        /// <param name="y">The power to raise the base to.</param>
        /// <returns>The sum of the digits of the exponentiation result.</returns>
        public static int Solve(int x, int y)
        {
            int sum = 0;
            string result = BigInteger.Pow(x, y).ToString();
            for (int i = 0; i < result.Length; i++)
            {
                sum += Int32.Parse(result[i].ToString());
            }
            return sum;
        }
    }
}