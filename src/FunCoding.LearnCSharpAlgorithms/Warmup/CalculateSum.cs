using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Warmup
{
    public class CalculateSum
    {
        #region calculate-sum-naive

        public int CallCalculateSumNaive()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n:
            var n = 100000000;
            var sum = CalculateSumNaive(n);
            sw.Stop();
            Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public long CalculateSumNaive(int n)
        {
            if (n <= 1)
            {
                throw new ArgumentException($"{nameof(n)} should not be less than 1.", nameof(n));
            }
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        #endregion


        #region calculate-sum-by-gauss

        public int CallCalculateSumByGauss()
        {
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            // You could change the below n:
            var n = 100000000;
            var sum = CalculateSumByGauss(n);
            sw.Stop();
            Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        public long CalculateSumByGauss(int n)
        {
            if (n <= 1)
            {
                throw new ArgumentException($"{nameof(n)} should not be less than 1.", nameof(n));
            }
            // Use long type for the numbers
            long temp = n;
            long sum = (1 + temp) * temp / 2;
            return sum;
        }
        #endregion
    }
}
