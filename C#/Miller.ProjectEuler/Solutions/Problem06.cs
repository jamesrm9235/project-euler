using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Sum square difference
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=6"/>
    public class Problem06
    {
        /// <summary>
        /// Iterates through every number up to and including the <paramref name="limit"/> to generate 2 sums:
        /// <para>
        /// A sum of the numbers
        /// </para>
        /// <para>
        /// A sum generated from the square of each number
        /// </para>
        /// </summary>
        /// <param name="limit">The number to count towards. The count is inclusive of this number.</param>
        /// <returns>
        /// The difference between the square of the sum and sum of the square.
        /// </returns>
        /// <remarks>
        /// 
        /// </remarks>
        public double Solve(int limit)
        {
            var sum = 0;
            double sumOfSquare = 0;

            for (int i = 1; i <= limit; i++)
            {
                sum += i;

                sumOfSquare += Math.Pow(i, 2);
            }

            var squareOfSum = Math.Pow(sum, 2);

            return squareOfSum - sumOfSquare;
        }
    }
}
