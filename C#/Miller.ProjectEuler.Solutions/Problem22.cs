using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=22
    /// </summary>
    public sealed class Problem22 : IProblem
    {
        public string Name => "Names scores";

        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private readonly string _names;

        public Problem22(string names)
        {
            if (string.IsNullOrEmpty(names))
            {
                throw new System.ArgumentException($"{nameof(names)} cannot be null or empty.");
            }

            _names = names.Replace("\"", "");
        }

        public string Solve()
        {
            var nameList = _names.Split(new char[] { ',' }).ToList();
            nameList.Sort();

            int totalScore = 0;

            for (int i = 0; i < nameList.Count; i++)
            {
                totalScore += ScoreName(nameList[i], i + 1);
            }

            return totalScore.ToString();
        }

        private int ScoreName(string name, int index)
        {
            int result = 0;
            foreach (var c in name)
            {
                // zero-based indexing must be considered when retrieving the actual value of character in alphabet
                result += Alphabet.IndexOf(c) + 1;
            }
            return result * index;
        }
    }
}