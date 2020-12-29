using System;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Names scores
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=22"/>
    public class Problem22
    {
        /// <summary>
        /// Loops through each name in <paramref name="commaDelimitedNames"/>.
        /// Each name is assigned a score based on the each letter in the name and its position in the alphabet.
        /// Finally, all of the scores are summed.
        /// </summary>
        /// <param name="commaDelimitedNames">A comma delimited string of names.</param>
        /// <returns>
        /// The sum of all name scores.
        /// </returns>
        public int Solve(string commaDelimitedNames)
        {
            var nameList = commaDelimitedNames
                .Replace("\"", "")
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            nameList.Sort();

            int totalScore = 0;

            for (int i = 0; i < nameList.Count; i++)
            {
                totalScore += nameList[i].AlphabeticalSum() * (i + 1);
            }

            return totalScore;
        }
    }
}
