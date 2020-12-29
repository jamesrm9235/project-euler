using System;
using System.Collections.Generic;

namespace Miller.ProjectEuler
{
    public static class ULongExtensions
    {
        /// <summary>
        /// Tests <paramref name="number"/> for primality with trial division.
        /// </summary>
        /// <param name="number">Number to test.</param>
        /// <returns>True if prime otherwise false.</returns>
        public static bool IsPrime(this ulong number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2 || number == 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            ulong divisor = 5;
            ulong limit = (ulong)Math.Ceiling(Math.Sqrt(number));
            while (divisor <= limit)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
                divisor += 2;
                if (number % divisor == 0)
                {
                    return false;
                }
                divisor += 4;
            }
            return true;
        }

        public static List<ulong> PrimeFactorization(this ulong number)
        {
            var factors = new List<ulong>();

            if (number % 2 == 0)
            {
                while (number % 2 == 0)
                {
                    number /= 2;
                    factors.Add(2);
                }
            }

            ulong oddDivisor = 3;
            while (number != 1)
            {
                if (number % oddDivisor == 0 && oddDivisor.IsPrime())
                {
                    while (number % oddDivisor == 0)
                    {
                         number /= oddDivisor;
                         factors.Add(oddDivisor);
                    }
                }
                oddDivisor += 2;
            }
            return factors;
        }
    }
}