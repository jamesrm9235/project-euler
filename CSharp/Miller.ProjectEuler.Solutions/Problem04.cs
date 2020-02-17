using System.Text;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=4
    /// </summary>
    public sealed class Problem04 : IProblem
    {
        public string Name => "Largest palindrome product";

        /// <summary>
        /// Finds the largest palindrome from the product of two 3-digit numbers.
        /// </summary>
        /// <returns>Returns 906609</returns>
        public string Solve()
        {
            var largestPalindrome = 0;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    var product = i * j;
                    if (product > largestPalindrome && IsPalindrome(product.ToString()))
                    {
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome.ToString();
        }

        /// <summary>
        /// Evaluates whether the string is a palindrome by comparing the string against its reverse.
        /// </summary>
        /// <param name="str">The string to evaluate.</param>
        /// <returns>True if the string is a palindrome and false otherwise.</returns>
        private bool IsPalindrome(string str)
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