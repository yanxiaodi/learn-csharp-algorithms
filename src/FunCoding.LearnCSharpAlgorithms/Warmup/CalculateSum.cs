using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.Warmup
{
    public class CalculateSum
    {
        #region calculate-sum-naive
        public int CalculateSumNaive()
        {
            // You could change the below n:
            var n = 1000000;
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");
            return 0;
        }
        #endregion


        #region calculate-sum-by-gauss
        public int CalculateSumByGauss()
        {
            // You could change the below n:
            var n = 10000;
            long sum = (1 + n) * n / 2;
            Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");
            return 0;
        }
        #endregion
    }
}
