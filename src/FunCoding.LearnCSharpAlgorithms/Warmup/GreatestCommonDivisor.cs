using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Warmup
{
    public class GreatestCommonDivisor
    {
        #region calculate-gcd-naive
        public int CallCalculateGreatestCommonDivisorNaive()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below a and b.
            var a = 3918848L;
            var b = 1653264L;
            var result = CalculateGreatestCommonDivisorNaive(a, b);
            Console.WriteLine($"The Greatest Common Divisor of {a} and {b} is {result}");
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }
        public long CalculateGreatestCommonDivisorNaive(long a, long b)
        {
            var result = 0L;
            for (var i = 1L; i < a + b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                }
            }
            return result;
        }
        #endregion

        #region calculate-gcd-euclidean

        public int CallCalculateGreatestCommonDivisorEuclidean()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below a and b.
            var a = 3918848L;
            var b = 1653264L;
            var result = CalculateGreatestCommonDivisorEuclidean(a, b);
            Console.WriteLine($"The Greatest Common Divisor of {a} and {b} is {result}");
            sw.Stop();
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public long CalculateGreatestCommonDivisorEuclidean(long a, long b)
        {
            if (a == 0 || b == 0)
            {
                return Math.Max(a, b);
            }
            var max = Math.Max(a, b);
            var min = Math.Min(a, b);
            var temp = max % min;
            return CalculateGreatestCommonDivisorEuclidean(min, temp);
        }
        #endregion
    }
}
