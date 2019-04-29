using System;
using System.Collections.Generic;
using System.Numerics;

namespace Miller.ProjectEuler.Solutions
{
    public static class Problem25
    {
        public static int Solve(int length)
        {
            return CalculateFibonacciSequence(length);
        }

        private static int CalculateFibonacciSequence(int digitLength)
        {
            var head = new BigInteger(1);
            var prev = new BigInteger(1);
            var i = 2;
            do
            {
                head += prev;
                prev = head - prev;
                i++;
            } while (head.ToString().Length < digitLength);
            return i;
        }
    }
}
