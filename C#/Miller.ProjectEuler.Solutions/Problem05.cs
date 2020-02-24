using Miller.ProjectEuler.Solutions.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=5
    /// </summary>
    public sealed class Problem05 : IProblem
    {
        public string Name => "Smallest multiple";

        private ulong _limit;

        public Problem05(ulong limit = 20)
        {
            _limit = limit;
        }

        public string Solve()
        {
            List<ulong> commonFactors = new List<ulong>();

            for (ulong i = 2; i < _limit; i++)
            {
                var primes = i.PrimeFactorization();
                foreach (var prime in primes)
                {
                    if (commonFactors.Contains(prime))
                    {
                        if (primes.Where(x => x == prime).Count() > commonFactors.Where(x => x == prime).Count())
                        {
                            while (commonFactors.Where(x => x == prime).Count() != primes.Where(x => x == prime).Count())
                            {
                                commonFactors.Add(prime);
                            }
                        }
                    }
                    else
                    {
                        commonFactors.Add(prime);
                    }
                }
            }


            ulong result = commonFactors.Aggregate((x, y) => x * y);
            return result.ToString();
        }
    }
}