using System;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=9
    /// </summary>
    public sealed class Problem09 : IProblem
    {
        public string Name => "Special Pythagorean triplet";

        private const int Circumference = 1000;

        /// <summary>
        /// Brute force solution.
        /// </summary>
        /// <returns>Product of the Pythagorean triplet whose sum is 1000.</returns>
        public string Solve()
        {
            uint a = 0, b = 0, c = 0;
            for (a = 1; a < Circumference; a++)
            {
                for (b = a; b < Circumference; b++)
                {
                    c = Circumference - a - b;
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        return (a * b * c).ToString();
                    }
                }
            }
            throw new System.Exception("No triples found");
        }
    }
}