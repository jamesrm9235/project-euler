using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Special Pythagorean triplet
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=9"/>
    public class Problem09
    {
        /// <summary>
        /// Brute force approach to finding the Pythagorean triplet whose sides equal <paramref name="perimeter"/>.
        /// </summary>
        /// <param name="perimeter">Default is 1000.</param>
        /// <returns>
        /// Product of the Pythagorean triplet whose sum is 1000.
        /// </returns>
        public uint Solve(uint perimeter = 1000)
        {
            for (uint a = 1; a < perimeter; a++)
            {
                uint b;

                for (b = a; b < perimeter; b++)
                {
                    uint c = perimeter - a - b;

                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        return a * b * c;
                    }
                }
            }
            throw new Exception("No triples found");
        }
    }
}