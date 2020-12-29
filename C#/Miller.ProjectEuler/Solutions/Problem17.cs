using System;
using System.Text;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Number letter counts
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=17"/>
    public class Problem17
    {
        /// <summary>
        /// Converts each number up to and including the <paramref name="limit"/> to its English representation (e.g. 1 to "one") and then counts the number of letters.
        /// </summary>
        /// <param name="limit">The numbers to write out in sequence. The sequence includes the limit. Default is 1000.</param>
        /// <returns>
        /// The number of letters excluding hyphens and spaces.
        /// </returns>
        public int Solve(int limit = 1000)
        {
            var builder = new StringBuilder();

            for (int i = 1; i <= limit; i++)
            {
                builder.Append(NumberAsWords(i));
            }

            var sequenceAsWords = builder.ToString();

            var cleaned = sequenceAsWords.Replace("-", "").Replace(" ", ""); // problem states that hyphens and empty spaces should not be counted

            return cleaned.Length;
        }

        /// <summary>
        /// Converts <paramref name="n"/> to its English representation (e.g. 1 to "one").
        /// <para>
        /// Note that this method can handle only numbers up to and including 1000.
        /// </para>
        /// </summary>
        /// <param name="n">Number to convert to its written form.</param>
        /// <returns>
        /// <paramref name="n"/> written out in English.
        /// </returns>
        /// <exception cref="Exception">Thrown when <paramref name="n"/> is greater than 1000.</exception>
        public string NumberAsWords(int n)
        {
            if (n == 0)
            {
                return "";
            }

            if (n < 1 || n > 1000)
            {
                throw new ArgumentException($"{n} must be a positive integer less than one hundred.");
            }

            if (n < 20)
            {
                return GetNumberPartAsWord(n);
            }
            else if (20 <= n && n < 100)
            {
                var ones = GetNumberPartAsWord(n % 10);
                var tens = GetNumberPartAsWord(n - (n % 10));
                return $"{tens} {ones}";
            }
            else if (100 <= n && n < 1000)
            {
                var tens = NumberAsWords(n % 100);
                var hundreds = GetNumberPartAsWord(n / 100);
                if (string.IsNullOrEmpty(tens))
                {
                    return $"{hundreds} hundred";
                }
                else
                {
                    return $"{hundreds} hundred and {tens}";
                }
            }
            else if (n == 1000)
            {
                return "one thousand";
            }
            else
            {
                throw new Exception("Cannot convert numbers greater than 1000 to its English representation");
            }
        }

        private string GetNumberPartAsWord(int n)
        {
            switch (n)
            {
                case 1:
                    return "one";

                case 2:
                    return "two";

                case 3:
                    return "three";

                case 4:
                    return "four";

                case 5:
                    return "five";

                case 6:
                    return "six";

                case 7:
                    return "seven";

                case 8:
                    return "eight";

                case 9:
                    return "nine";

                case 10:
                    return "ten";

                case 11:
                    return "eleven";

                case 12:
                    return "twelve";

                case 13:
                    return "thirteen";

                case 14:
                    return "fourteen";

                case 15:
                    return "fifteen";

                case 16:
                    return "sixteen";

                case 17:
                    return "seventeen";

                case 18:
                    return "eighteen";

                case 19:
                    return "nineteen";

                case 20:
                    return "twenty";

                case 30:
                    return "thirty";

                case 40:
                    return "forty";

                case 50:
                    return "fifty";

                case 60:
                    return "sixty";

                case 70:
                    return "seventy";

                case 80:
                    return "eighty";

                case 90:
                    return "ninety";

                default:
                    return "";
            }
        }
    }
}
