using System;
using System.Collections.Generic;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=25
    /// </summary>
    public static class Problem25
    {
        /// <summary>
        /// Finds the index of the term in a Fibonacci sequence that has a digit length
        /// greater than or equal to the value passed to this method.
        /// </summary>
        /// <param name="digitLength">The number of digits the terminating term must be equal or greater than.</param>
        /// <returns>The index of the term that terminates the Fibonacci sequence.</returns>
        public static int Solve(int digitLength)
        {
            var head = new BigInteger(1);
            var prev = new BigInteger(1);
            var index = 2;
            do
            {
                head += prev;
                prev = head - prev;
                index++;
            } while (head.ToString().Length < digitLength);
            return index;
        }
    }
}
