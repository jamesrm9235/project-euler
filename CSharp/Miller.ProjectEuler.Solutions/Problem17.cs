using System;
using System.Linq;
using System.Text;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=17
    /// </summary>
    public static class Problem17
    {
        public static int Solve()
        {
            var result = MakeStringOfSanitizedNumbersAsWords(1000);
            return result.Length;
        }

        public static string MakeStringOfSanitizedNumbersAsWords(int countUpTo)
        {
            if (countUpTo < 1)
            {
                throw new ArgumentException($"{nameof(countUpTo)} must be a positive integer greater than or equal to 1.");
            }

            var builder = new StringBuilder();
            for (int i = 1; i <= countUpTo; i++)
            {
                builder.Append(ConvertNumberToWord(i));
            }
            return Sanitize(builder.ToString());
        }

        /// <summary>
        /// Removes spaces and hyphens from the string.
        /// </summary>
        /// <param name="str">The string to sanitize.</param>
        /// <returns>A string without spaces and hyphens.</returns>
        public static string Sanitize(string str)
        {
            return str.Replace("-", "").Replace(" ", "");
        }

        public static string ConvertNumberToWord(int i)
        {
            if (i == 0)
            {
                return "";
            }

            if (i < 1 || i > 1000)
            {
                throw new ArgumentException($"{i} must be a positive integer less than one hundred.");
            }



            if (i < 20)
            {
                return GetNumberPartAsWord(i);
            }
            else if (20 <= i && i < 100)
            {
                var ones = GetNumberPartAsWord(i % 10);
                var tens = GetNumberPartAsWord(i - (i % 10));
                return $"{tens} {ones}";
            }
            else if (100 <= i && i < 1000)
            {
                var tens = ConvertNumberToWord(i % 100);
                var hundreds = GetNumberPartAsWord(i / 100);
                if (string.IsNullOrEmpty(tens))
                {
                    return $"{hundreds} hundred";
                }
                else
                {
                    return $"{hundreds} hundred and {tens}";
                }

            }
            else if (i == 1000)
            {
                return "one thousand";
            }
            else
            {
                throw new Exception();
            }
        }

        public static string GetNumberPartAsWord(int n)
        {
            switch (n)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                default: return "";
            }
        }
    }
}