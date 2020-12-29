using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// 1000-digit Fibonacci number
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=25"/>
    public class Problem25
    {
        /// <summary>
        /// Finds the index of the term in the Fibonacci sequence that has a length greater than or equal to <paramref name="length"/>.
        /// </summary>
        /// <param name="length">The number of digits the target term must be equal or greater than.</param>
        /// <returns>
        /// The index of the term that terminates the Fibonacci sequence.
        /// </returns>
        public int Solve(int length)
        {
            var head = new BigInteger(1);
            var prev = new BigInteger(1);
            var index = 2;

            do
            {
                head += prev;
                prev = head - prev;
                index++;
            } while (head.ToString().Length < length);
            return index;
        }
    }
}
