using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Number spiral diagonals
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=28"/>
    public class Problem28
    {
        /// <summary>
        /// Generates a single dimension array containing the value of each top-right cell of the grid for each layer.
        /// The sum of all diagonal values is calculated by applying some insights. See the remarks for a full explanation.
        /// </summary>
        /// <param name="layers">The number of layers in the grid. Default is 1001.</param>
        /// <returns>
        /// The sum of all diagonal values plus the center.
        /// </returns>
        /// <remarks>
        /// This problem can be solved without generating a matrix.
        /// The following patterns are observed:
        /// <para>
        /// 1. The perimeter of the grid increases by a factor of 8 with each layer (e.g. the 1st layer contains 8 values, the 2nd layer 16, and so on).
        /// </para>
        /// <para>
        /// 2. The top-right value of each layer is equal to the number of values at the current layer plus the previous layer's top-right value.
        /// </para>
        /// <para>
        /// 3. The value of each layer's corner is equal to the top-right value minus 2, 4, or 6 times the current layer.
        /// </para>
        /// </remarks>
        public int Solve(int layers = 1001)
        {
            int half = (int)Math.Round((double)layers / 2, MidpointRounding.ToEven);

            var topRightValues = new int[half + 1]; // 1 to offset addition of center
            topRightValues[0]  = 1;                 // initialize with center value

            var sum = topRightValues[0];

            for (int i = 1; i <= half; i++) // arbitrary whether the limit is based on x or y as both dimensions should be equal
            {
                var topRight = topRightValues[i - 1] + (8 * i);

                topRightValues[i] = topRight;

                sum += topRight;
                sum += topRight - (2 * i); // top left
                sum += topRight - (4 * i); // bottom left
                sum += topRight - (6 * i); // bottom right
            }

            return sum;
        }
    }
}
