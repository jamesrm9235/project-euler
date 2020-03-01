using System.Linq;
using Miller.ProjectEuler.Solutions.Utils;

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
                totalScore += nameList[i].AlphabeticalSum() * (i + 1);
            }

            return totalScore.ToString();
        }
    }
}