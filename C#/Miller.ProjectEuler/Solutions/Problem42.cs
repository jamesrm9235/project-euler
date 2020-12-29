using System.Collections.Generic;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Coded triangle numbers
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=42"/>
    public class Problem42
    {
        private List<int> triangleNumbers = new List<int>() { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };

        private List<int> TriangleNumbers => triangleNumbers;

        /// <summary>
        /// Counts the number of "triangle words" found in <paramref name="words"/>.
        /// </summary>
        /// <param name="words">A comma delimited string containing words.</param>
        /// <returns>
        /// The number of triangle words found in <paramref name="words"/>.
        /// </returns>
        /// <remarks>
        /// A "triangle word" is defined as a word whose value is a triangle number.
        /// The word's value is derived from assigning a value to each letter based on its alphabetical position and taking the sum.
        /// A triangle number is a number calculated from 0.5 * n * (n + 1)
        /// </remarks>
        public int Solve(string words)
        {
            int triangleWords = 0;

            string[] wordsList = words
                .Replace("\"", "")
                .Split(',');

            foreach (string word in wordsList)
            {
                int value = word.AlphabeticalSum();

                triangleWords += IsTriangleNumber(value) ? 1 : 0;
            }
            return triangleWords;
        }

        private bool IsTriangleNumber(int wordValue)
        {
            if (triangleNumbers.Contains(wordValue))
            {
                return true;
            }

            int maxTriNumber = triangleNumbers.Last();
            if (wordValue < maxTriNumber)
            {
                return false;
            }

            int index = triangleNumbers.Count() + 1;
            while (wordValue > maxTriNumber)
            {
                int triNumber = index * (index + 1) / 2;

                triangleNumbers.Add(triNumber);

                maxTriNumber = triNumber;

                if (wordValue == maxTriNumber)
                {
                    return true;
                }
                index += 1;
            }
            return false;
        }
    }
}
