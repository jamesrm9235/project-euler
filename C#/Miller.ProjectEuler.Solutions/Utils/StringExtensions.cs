using System;

namespace Miller.ProjectEuler.Solutions.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts each letter to a number corresponding to its alphabetical position and adds these values to form a sum.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int AlphabeticalSum(this string word)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string capsWord = word.ToUpper();
            int sum = 0;
            foreach (var c in capsWord)
            {
                sum += alphabet.IndexOf(c) + 1;
            }
            return sum;
        }
    }
}