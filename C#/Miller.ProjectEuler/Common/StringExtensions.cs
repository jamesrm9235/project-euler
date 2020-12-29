using System.Text;

namespace Miller.ProjectEuler
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts each letter to a number corresponding to its position in the alphabet and adds this values to a sum.
        /// </summary>
        /// <param name="word">Word to calculate sum.</param>
        /// <returns>
        /// Sum calculated from each letter's position in the alphabet.
        /// </returns>
        public static int AlphabeticalSum(this string word)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string caps = word.ToUpper();
            int sum = 0;

            foreach (var c in caps)
            {
                sum += alphabet.IndexOf(c) + 1;
            }
            return sum;
        }

        /// <summary>
        /// Reverses <paramref name="str"/> and checks if it is the same as the original argument.
        /// </summary>
        /// <param name="str">String to test.</param>
        /// <returns>True if is a palindrome and false otherwise.</returns>
        public static bool IsPalindrome(this string str)
        {
            var builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            var reversed = builder.ToString();
            return str == reversed;
        }
    }
}
