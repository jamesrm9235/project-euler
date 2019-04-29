using System;
using System.Collections.Generic;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    /// <summary>
    /// https://projecteuler.net/problem=16
    /// </summary>
    public static class Problem16
    {
        public static int Solve(int x, int y)
        {
            int sum = 0;
            string s = BigInteger.Pow(x, y).ToString();
            for (int i = 0; i < s.Length; i++)
            {
                sum += Int32.Parse(s[i].ToString());
            }
            return sum;
        }
    }
}