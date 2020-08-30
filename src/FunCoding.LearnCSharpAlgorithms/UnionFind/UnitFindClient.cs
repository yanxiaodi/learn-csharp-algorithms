using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunCoding.LearnCSharpAlgorithms.UnionFind
{
    public class UnitFindClient
    {
        #region quick-find
        public int QuickFindTest()
        {
            // You can change the value of n to check the performance
            int n = 10000;
            Random randomSeed = new Random(System.DateTime.Now.Millisecond);
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var uf = new QuickFindUf(n);
            for (int i = 0; i < n * 4 / 5; i++)
            {
                var p = randomSeed.Next(0, n);
                var q = randomSeed.Next(0, n);
                if (!uf.Connected(p, q))
                {
                    uf.Union(p, q);
                }
            }
            sw.Stop();
            Console.WriteLine($"{uf.Count()} components");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }
        #endregion

        #region quick-union

        public int QuickUnionTest()
        {
            // You can change the value of n to check the performance
            int n = 10000;
            Random randomSeed = new Random(System.DateTime.Now.Millisecond);
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var uf = new QuickUnionUf(n);
            for (int i = 0; i < n * 4 / 5; i++)
            {
                var p = randomSeed.Next(0, n);
                var q = randomSeed.Next(0, n);
                if (!uf.Connected(p, q))
                {
                    uf.Union(p, q);
                }
            }
            sw.Stop();
            Console.WriteLine($"{uf.Count()} components");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        #endregion

        #region weighted-quick-union

        public int WeightedQuickUnionTest()
        {
            // You can change the value of n to check the performance
            int n = 1000000;
            Random randomSeed = new Random(System.DateTime.Now.Millisecond);
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var uf = new WeightedQuickUnionUf(n);
            for (int i = 0; i < n * 4 / 5; i++)
            {
                var p = randomSeed.Next(0, n);
                var q = randomSeed.Next(0, n);
                if (!uf.Connected(p, q))
                {
                    uf.Union(p, q);
                }
            }
            sw.Stop();
            Console.WriteLine($"{uf.Count()} components");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        #endregion

        #region weighted-quick-union-path-compression

        public int WeightedQuickUnionPathCompressionTest()
        {
            // You can change the value of n to check the performance
            int n = 1000000;
            Random randomSeed = new Random(System.DateTime.Now.Millisecond);
            // Create a Stopwatch to record the time.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var uf = new WeightedQuickUnionWithPathCompressionUf(n);
            for (int i = 0; i < n * 4 / 5; i++)
            {
                var p = randomSeed.Next(0, n);
                var q = randomSeed.Next(0, n);
                if (!uf.Connected(p, q))
                {
                    uf.Union(p, q);
                }
            }
            sw.Stop();
            Console.WriteLine($"{uf.Count()} components");
            Console.WriteLine($"It runs {sw.ElapsedMilliseconds} milliseconds");
            return 0;
        }

        #endregion


    }
}
