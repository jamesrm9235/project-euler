using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Power digit sum
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=16"/>
    public class Problem16
    {
        /// <summary>
        /// Calculates the sum of the digits of the exponentiation result of <paramref name="x"/> to the power of <paramref name="y"/>.
        /// </summary>
        /// <param name="x">The base integer.</param>
        /// <param name="y">The power to raise the base to.</param>
        /// <returns>The sum of the digits of the exponentiation result.</returns>
        public int Solve(int x = 2, int y = 1000)
        {
            int sum = 0;

            string result = BigInteger.Pow(x, y).ToString();

            for (int i = 0; i < result.Length; i++)
            {
                sum += int.Parse(result[i].ToString());
            }
            return sum;
        }
    }
}
