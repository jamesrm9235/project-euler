using System.Collections.Generic;
using System.Linq;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// Smallest multiple
    /// </summary>
    /// <seealso cref="https://projecteuler.net/problem=5"/>
    public class Problem05
    {
        /// <summary>
        /// Generates primes for each number up to and including the <paramref name="limit"/> and adds each prime to a list of common prime factors if:
        /// <para>
        /// The prime is not in the list
        /// </para>
        /// <para>
        /// The count of primes in the list is greater than the count of primes in the common list
        /// </para>
        /// Finally, the list of common prime factors is used to calculate a product which is the smallest multiple.
        /// </summary>
        /// <param name="limit">Default is 20.</param>
        /// <returns>
        /// The smallest multiple of every number up to and including the <paramref name="limit"/>.
        /// </returns>
        public ulong Solve(ulong limit = 20)
        {
            List<ulong> commonFactors = new List<ulong>();

            for (ulong i = 2; i < limit; i++)
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

            return result;
        }
    }
}
