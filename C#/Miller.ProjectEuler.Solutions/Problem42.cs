using Miller.ProjectEuler.Solutions.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=42
    /// </summary>
    public sealed class Problem42 : IProblem
    {
        public string Name => "Coded triangle numbers";

        private List<int> _triangleNumbers;
        private readonly string _words;
        public Problem42(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                throw new System.ArgumentException($"{nameof(words)} cannot be null or empty.");
            }
            _words = words.Replace("\"", "");

            // Initialize the list with information from the problem
            _triangleNumbers = new List<int> { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };
        }

        public string Solve()
        {
            int triangleWords = 0;
            string[] wordsList = _words.Split(',');
            foreach (string word in wordsList)
            {
                int value = word.AlphabeticalSum();
                triangleWords += IsTriangleNumber(value) ? 1 : 0;
            }
            return triangleWords.ToString();
        }

        private bool IsTriangleNumber(int wordValue)
        {
            if (_triangleNumbers.Contains(wordValue))
            {
                return true;
            }

            int maxTriNumber = _triangleNumbers.Last();
            if (wordValue < maxTriNumber)
            {
                return false;
            }

            int index = _triangleNumbers.Count() + 1;
            while (wordValue > maxTriNumber)
            {
                int triNumber = (index * (index + 1)) / 2;
                _triangleNumbers.Add(triNumber);
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