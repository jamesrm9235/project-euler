using System;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    public static class Problem20
    {
        public static int Solve(int n)
        {
            var result = Factorial(n).ToString();
            var sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += Int32.Parse(result[i].ToString());
            }
            return sum;
        }

        public static BigInteger Factorial(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException();
            }

            if (n == 1)
            {
                return 1;
            }

            var product = new BigInteger(n);
            for (int i = n - 1; i != 1; i--)
            {
                product *= i;
            }

            return product;
        }

        // public static int RecursiveFactorial(int n)
        // {
        //     if (n == 1)
        //     {
        //         return 1;
        //     }
        //     return n * Factorial(n--);
        // }
    }
}