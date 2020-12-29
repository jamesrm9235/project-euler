namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Largest palindrome product
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=4"/>
    public class Problem04
    {
        /// <summary>
        /// Uses a nested loop to generate products for every 3-digit number between 100 and 999.
        /// Each product is checked if it is a palindrome.
        /// </summary>
        /// <returns>The largest palindrome product. Ranges are hardcoded so the result is always 906,609.</returns>
        public int Solve()
        {
            var largestPalindrome = 0;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    var product = i * j;
                    if (product > largestPalindrome && product.ToString().IsPalindrome())
                    {
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome;
        }
    }
}
